
using UnityEngine;

public class BambooScriptTwo : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y < -7.94f)
        {
            transform.position = new Vector3(1.6f, 9.9f, 0);
        }
    }
}
