using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public int goggleLevelplayer1 = 0;
    public int goggleLevelplayer2 = 0;

    public GameObject[] night1;
    public GameObject[] heat1;

    public GameObject[] night2;
    public GameObject[] heat2;



    public Material[] mat;

    // Start is called before the first frame update
    void Start()
    {
        
        //Loop for the entire size of the array, 10 in this case
        //for (int i = 0; i < numHeatBoxes; i++)
        //{
        //    //Create the game object
        //    //arr[i] = GameObject.Instantiate(Resources.Load("Tile")) as GameObject;

        //    //Position it in the scene
        //    //arr[i].transform.position = new Vector3(i * 0.32f, 0, 0);
        //}

    }

    // Update is called once per frame
    void Update()
    {



        switch(goggleLevelplayer1)
        {
            case 0:
                foreach (GameObject g in heat1)
                    g.active = false;

                foreach (GameObject g in night1)
                    g.GetComponent<MeshRenderer>().material = mat[0];
                break;
            case 1:
                foreach (GameObject g in night1)
                    g.GetComponent<MeshRenderer>().material = mat[1];
                foreach (GameObject g in heat1)
                    g.active = false;
                break;
            case 2:
                foreach (GameObject g in heat1)
                    g.active = true;
                foreach (GameObject g in night1)
                    g.GetComponent<MeshRenderer>().material = mat[0];
                break;
            default:
                break;
        }

        switch (goggleLevelplayer2)
        {
            case 0:
                foreach (GameObject g in heat2)
                    g.active = false;

                foreach (GameObject g in night2)
                    g.GetComponent<MeshRenderer>().material = mat[0];
                break;
            case 1:
                foreach (GameObject g in night2)
                    g.GetComponent<MeshRenderer>().material = mat[1];
                foreach (GameObject g in heat2)
                    g.active = false;
                break;
            case 2:
                foreach (GameObject g in heat2)
                    g.active = true;
                foreach (GameObject g in night2)
                    g.GetComponent<MeshRenderer>().material = mat[0];
                break;
            default:
                break;
        }


    }
}
