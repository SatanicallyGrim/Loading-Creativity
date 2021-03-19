using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNick : MonoBehaviour
{
    public float speed = 20f;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
        
   
    




