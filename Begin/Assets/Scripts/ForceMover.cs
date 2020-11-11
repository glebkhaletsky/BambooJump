using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMover : MonoBehaviour
{
    public static Vector2 derection=new Vector2(0,-1);
    public static float accelaration=0.1f;
    public Rigidbody2D rb;


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(derection * accelaration);
    }
}
