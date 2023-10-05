using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; // Field
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) // Input. doesn't exict in C#. Just in Rider
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, 300, 0);
        }

        transform.Translate(x:0, y:0,z:speed);
    }
}
