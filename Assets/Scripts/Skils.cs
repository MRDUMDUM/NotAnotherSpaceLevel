using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skils : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    public int HackingLevel;
    public int JumpingLevel;

    public GameObject[] jump;
    public GameObject[] hack;

    public Color jumpActive;
    public Color jumpDown;

    public Color hackActive;
    public Color hackdown;

    public float alphaLevel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HackingLevel = player.GetComponent<MagnusPlayerMovement>().hackingLevel;
        JumpingLevel = player.GetComponent<MagnusPlayerMovement>().jumpLevel;
        if (player.GetComponent<MagnusPlayerMovement>().r1Pressed || player.GetComponent<MagnusPlayerMovement>().l1Pressed)
        {
            if (alphaLevel < 0.5f)
            {
                alphaLevel += 0.01f;
            }
            if (player.GetComponent<MagnusPlayerMovement>().r1Pressed && true) // If levels are available
            {
                if (player.GetComponent<MagnusPlayerMovement>().downPressed && player.GetComponent<MagnusPlayerMovement>().jumpLevel < 3)
                {
                    player.GetComponent<MagnusPlayerMovement>().jumpLevel++;
                    // availableLevels--;
                }
                if (player.GetComponent<MagnusPlayerMovement>().rightPressed && player.GetComponent<MagnusPlayerMovement>().hackingLevel < 3)
                {
                    player.GetComponent<MagnusPlayerMovement>().hackingLevel++;
                    // availableLevels--;
                }
                if (player.GetComponent<MagnusPlayerMovement>().leftPressed && player.GetComponent<MagnusPlayerMovement>().GoggleLevel < 2)
                {
                    player.GetComponent<MagnusPlayerMovement>().goggleLevel++;
                    // availableLevels--;
                }
            }
            else if (player.GetComponent<MagnusPlayerMovement>().l1Pressed)
            {
                if (player.GetComponent<MagnusPlayerMovement>().downPressed && player.GetComponent<MagnusPlayerMovement>().jumpLevel > 0)
                {
                    player.GetComponent<MagnusPlayerMovement>().jumpLevel--;
                    //availableLevels++;
                }
                else if (player.GetComponent<MagnusPlayerMovement>().leftPressed && player.GetComponent<MagnusPlayerMovement>().goggleLevel > 0)
                {
                    player.GetComponent<MagnusPlayerMovement>().goggleLevel--;
                    //availableLevels++;
                }
                else if (player.GetComponent<MagnusPlayerMovement>().rightPressed && player.GetComponent<MagnusPlayerMovement>().hackingLevel > 0)
                {
                    player.GetComponent<MagnusPlayerMovement>().hackingLevel--;
                    //availableLevels++;
                }
            }
        }
        else
        {
            if (alphaLevel > 0.009f)
            {
                alphaLevel -= 0.01f;
            }
        }

        foreach (GameObject j in jump)
        {

           // j.GetComponent<SpriteRenderer>().color = jumpDown + new Color(0, 0, 0, alphaLevel);
             //j.GetComponent<SpriteRenderer>().color
        }
        UpdateJump();
    }


    void UpdateJump()
    {
        switch (JumpingLevel)
        {
            case 0:
                foreach (GameObject j in jump)
                {
                    j.GetComponent<SpriteRenderer>().color = jumpDown;
                }
            break;
            case 1:
                jump[0].GetComponent<SpriteRenderer>().color = jumpActive;
                jump[1].GetComponent<SpriteRenderer>().color = jumpDown;
                jump[2].GetComponent<SpriteRenderer>().color = jumpDown;
                break;
            case 2:
                jump[1].GetComponent<SpriteRenderer>().color = jumpActive;
                jump[2].GetComponent<SpriteRenderer>().color = jumpDown;
                break;
            case 3:
                jump[2].GetComponent<SpriteRenderer>().color = jumpActive;
                break;
        }
           
    }
}
