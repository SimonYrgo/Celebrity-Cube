using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CubeMovement : MonoBehaviour
{
    // Rigidbody cube; // skapa en variabel som h�mtar 
    float horizontal;
    float vertical;




    void Start()
    {
        // cube = GetComponent<();
        
    }

   
    void Update()
    {
        //horizontal = Input.GetAxisRaw("Horizontal"); // kollar A och D tangenter och g�r till -1, 0, 1 v�rden av input -1 v�nster 0 stilla , 1 h�ger
        // vertical = Input.GetAxisRaw("Vertical"); // kollar ws tangenter och ger v�rde -1, 0, 1 
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(0,45,0);


        }
    }

 
}


