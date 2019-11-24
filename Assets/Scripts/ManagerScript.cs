using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public int goggleLevel = 0;
    int numHeatBoxes = 4;
    public GameObject[] arr;

    // Start is called before the first frame update
    void Start()
    {
        arr = new GameObject[numHeatBoxes];
        //Loop for the entire size of the array, 10 in this case
        for (int i = 0; i < numHeatBoxes; i++)
        {
            //Create the game object
            arr[i] = GameObject.Instantiate(Resources.Load("Tile")) as GameObject;

            //Position it in the scene
            arr[i].transform.position = new Vector3(i * 0.32f, 0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        switch(goggleLevel)
        {
            case 0:
                foreach (GameObject g in arr)
                    g.active = false;
                break;
            case 1:
                foreach (GameObject g in arr)
                    g.active = true;
                break;
            case 2:
                foreach (GameObject g in arr)
                    g.active = false;
                break;
            default:
                break;
        }


    }
}
