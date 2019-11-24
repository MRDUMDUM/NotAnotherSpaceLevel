using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePod : MonoBehaviour
{
    public float podSpeed;
    public bool finish = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {
            transform.Translate(Vector3.right * podSpeed * Time.deltaTime, Space.Self);
        }
        
    }
}
