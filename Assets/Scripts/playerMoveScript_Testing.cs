using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveScript_Testing : MonoBehaviour
{

    public float zeroGMoveForce = 0f;
    public float normalMoveForce = 0f;
    private float moveforce = 0f;
    private Rigidbody2D rigidbody2;
    public float rotForce = 0f;
    public float jumpForce = 0f;
    public bool inZeroGZone = false;
    private float origGravityScale = 0f;
    public string zeroGTag = "";
    public string hackingTag = "";
    private float origLinearDrag = 0f;
    public float zeroGravityLinearDrag = 0f;
    private float origAngulerDrag = 0f;
    public float zeroGravityAngulerDrag = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        origGravityScale = rigidbody2.gravityScale;
        origLinearDrag = rigidbody2.drag;
        origAngulerDrag = rigidbody2.angularDrag;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal") * moveforce;
        float v = inZeroGZone ? Input.GetAxisRaw("Vertical") * moveforce : 0f;

        rigidbody2.AddForce(new Vector2(h, v));
        
    }
    private void LateUpdate()
    {
        moveforce = inZeroGZone ? zeroGMoveForce : normalMoveForce;
        rigidbody2.gravityScale = inZeroGZone ? 0f : origGravityScale;
        rigidbody2.drag = inZeroGZone ? zeroGravityLinearDrag : origLinearDrag;
        rigidbody2.angularDrag = inZeroGZone ? zeroGravityAngulerDrag : origAngulerDrag;

        if (Input.GetKeyDown(KeyCode.Space) && !inZeroGZone)
        {
            rigidbody2.AddForce(Vector2.up * jumpForce);
            rigidbody2.AddTorque(-rotForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "ZeroG")
        {
            inZeroGZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ZeroG")
        {
            inZeroGZone = false;
        }
    }
}
