using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwapQuads : MonoBehaviour
{
    GameObject[,] CubeCoordinates = new GameObject[3,4]; 

    public GameObject[] CubeCoordinatesArray; // befolkad genom slots på scriptet 

    private void Start()
    {
        
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (i == 0)
                {
                   CubeCoordinates[i, j] = CubeCoordinatesArray[j];
                }

                else if (i == 1)
                {
                    CubeCoordinates[i, j] = CubeCoordinatesArray[4 + j];
                }

                else if(i == 2)
                {
                    CubeCoordinates[i, j] = CubeCoordinatesArray[8 + j];
                }
               

                
            }



        }


        Debug.Log(CubeCoordinates[0, 0].name);
        Debug.Log(CubeCoordinates[1, 0].name);
        Debug.Log(CubeCoordinates[2, 0].name);
    }

    

    
    public void Swap(int row1, int col1, int row2, int col2) 
    {
       
        
        


    }
    

}
