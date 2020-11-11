using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRunScript : MonoBehaviour
{
    
    void FixedUpdate()
    {
        transform.Translate(new Vector3(-0.02f, -0.01f, 0));
        if (transform.position.x < -10) // если сюрикен опустился ниже -7 по оси Y, то...
        {
            Destroy(gameObject, 1); // ему пизда ^_^
        }
    }
}
