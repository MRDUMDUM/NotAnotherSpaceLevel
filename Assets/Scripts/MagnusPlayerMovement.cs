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

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        initialTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
          new Vector2(transform.position.x + 0.5f, transform.position.y - 0.51f), groundLayers);

        Jump();
        transform.Translate(movementSpeed * Input.GetAxis("Horizontal" + playerNumber.ToString()) * Time.deltaTime, 0f, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, initialTransform.rotation, 0.0f);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump" + playerNumber.ToString()) && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
