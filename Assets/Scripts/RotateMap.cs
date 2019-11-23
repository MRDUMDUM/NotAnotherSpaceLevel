using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMap : MonoBehaviour
{
    public float waitTime = 2f;
    public float smooth = 1f;

    private Vector3 targetAngles;

    private bool rotated = false;

    public GameObject player;

     
    private IEnumerator RotateWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotated == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                targetAngles = transform.eulerAngles + 180f * Vector3.forward;
                player.GetComponent<Rigidbody2D>().isKinematic = false;
                player.GetComponent<playerMoveScript_Testing>().enabled = false;
                rotated = true;
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                targetAngles = transform.eulerAngles - 180f * Vector3.forward;
                
                rotated = false;
            }
                
        }

        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime);
    }

    private IEnumerator wRotateWaitTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

    }
}
