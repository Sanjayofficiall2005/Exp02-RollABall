using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Xforce = 5.0f;
    public float Zforce = 5.0f;
    public float Yforce = 100.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - Xforce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = x + Xforce;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z = z - Zforce;
        }
        if (Input.GetKey(KeyCode.X))
        {
            z = z + Zforce;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            y = yforce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}