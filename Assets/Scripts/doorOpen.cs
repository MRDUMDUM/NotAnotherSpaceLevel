using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

    public float speed = 10;
    public Transform door_1;
    public Transform door_2;
    float door_1_orig_pos;
    float prev_player_pos_x;
    bool isLocked = false;

    // Use this for initialization
    void Start () {
        door_1_orig_pos = door_1.transform.position.y;
        prev_player_pos_x = transform.position.x;
    }

    // Update is called once per frame
    void Update () {

        // Move the Player
        float h = Input.GetAxis("Horizontal");
        Vector3 tempVect = new Vector3(h, 0, 0);
        tempVect = tempVect * speed * Time.deltaTime;
        transform.position += tempVect;

        // Move the door
        float distance = Vector3.Distance(transform.position, door_1.transform.position);

        if (!isLocked)
        {
            if (!prev_player_pos_x.Equals(transform.position.x))
            {
                if (distance < 2.5f)
                {
                    Vector3 up = new Vector3(0, 0.1f, 0);
                    door_1.transform.position += up;
                    door_2.transform.position -= up;
                }
                else if (distance >= 2.5f && door_1.transform.position.y > door_1_orig_pos)
                {
                    Vector3 down = new Vector3(0, 0.1f, 0);
                    door_1.transform.position -= down;
                    door_2.transform.position += down;
                }
            }

            prev_player_pos_x = transform.position.x;
        }
    }
}
