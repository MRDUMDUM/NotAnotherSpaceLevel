using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusPlayerMovement : MonoBehaviour
{
    private Transform initialTransform; 
    public float movementSpeed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayers;
    public int playerNumber;

    public bool stunned;
    public float stunTimer;

    public int jumpLevel = 0;
    public int goggleLevel = 0;
    public int hackingLevel = 0;

    public int jumps;

    public bool isGrounded;

    private Rigidbody2D rigidbody2;
    //zeroG

    public bool inZeroGZone = false;
    public bool canHack = false;
    private float origGravityScale = 0f;
    
    private float origLinearDrag = 0f;
    public float zeroGravityLinearDrag = 0f;
    private float origAngulerDrag = 0f;
    public float zeroGravityAngulerDrag = 0f;

    public float groundOffset;

    // trigger tags

    public string zeroGTag = "";
    public string hackingTag = "";


    //Hacking
    public int HackingLevel = 0;
    public float hacktimer = 2f;

    public bool r1Pressed;
    public bool downPressed;
    public bool rightPressed;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        origGravityScale = rigidbody2.gravityScale;
        origLinearDrag = rigidbody2.drag;
        origAngulerDrag = rigidbody2.angularDrag;
        initialTransform = transform;
        stunned = false;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
          new Vector2(transform.position.x + 0.5f, transform.position.y - 0.60f + groundOffset), groundLayers);

        if (!stunned)
        {
            Jump();
            Hack();

            float h = Input.GetAxisRaw("Horizontal" + playerNumber.ToString()) * movementSpeed;
            float v = inZeroGZone ? Input.GetAxisRaw("Vertical" + playerNumber.ToString()) * movementSpeed : 0f;

            rigidbody2.AddForce(new Vector2(h, v));
        }
        //transform.Translate(movementSpeed * Input.GetAxis("Horizontal" + playerNumber.ToString()) * Time.deltaTime, 0f, 0f);
        //transform.rotation = Quaternion.Slerp(transform.rotation, initialTransform.rotation, 0.0f);
        stunTimer = max(stunTimer - Time.deltaTime, 0);
        if (stunTimer == 0)
            stunned = false;
    }

    void Jump()
    {
        if (isGrounded)
            jumps = 0;

        if (Input.GetButtonDown("Jump" + playerNumber.ToString()) && (jumps < jumpLevel || isGrounded) && !inZeroGZone && jumpLevel > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jumps++;
        }
    }

    void Hack()
    {
        if (Input.GetButtonDown("Hack" + playerNumber.ToString()) && canHack)
        {
            Debug.Log("Hacking");
        }

        if (Input.GetKeyDown(KeyCode.E) && canHack)
        {
            Debug.Log("Hacking");
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "zeroGTag")
        {
            inZeroGZone = true;
        }
        if (other.gameObject.tag == "hackingTag")
        {
            canHack = true;
        }
        if (other.gameObject.tag == "Heat")
        {
            stunned = true;
            stunTimer = 5f;
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 10, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
         
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ZeroG")
        {
            inZeroGZone = false;
        }

        if (other.gameObject.tag == "hackingTag")
        {
            canHack = false;
        }

        
    }

    private float max(float a, float b)
    {
        if (a >= b)
            return a;
        else
            return b;
    }
}