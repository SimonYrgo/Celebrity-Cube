using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CubeMovement : MonoBehaviour
{
    // Rigidbody cube; // skapa en variabel som hämtar 
    float horizontal;
    float vertical;




    void Start()
    {
        // cube = GetComponent<();
        
    }

   
    void Update()
    {
        //horizontal = Input.GetAxisRaw("Horizontal"); // kollar A och D tangenter och gör till -1, 0, 1 värden av input -1 vänster 0 stilla , 1 höger
        // vertical = Input.GetAxisRaw("Vertical"); // kollar ws tangenter och ger värde -1, 0, 1 
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(0,45,0);


        }
    }

 
}


