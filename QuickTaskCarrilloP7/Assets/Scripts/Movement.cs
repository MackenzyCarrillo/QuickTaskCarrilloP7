using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
           

        }
    }
}