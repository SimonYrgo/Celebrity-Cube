using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPuzzleDone // :  MonoBehaviour  // n�r vi �rver fr�n MonoBehaviou f�r vi s� kan vi s�tta scriptet som en komponent, vi kan inte dra som komponent till GameObject ska den inte f�rekomma ute i Unity s� kan man g�ra s�
{
    
    public void CheckPuzzleSolved(GameObject[,] QuadCoordinatesMultiDimArray) // s�ger att vi kan ta in ett object av typen multidimesionellt GameObjects array som parameter till v�r funktion
    {
        
        GameObject quad1A = QuadCoordinatesMultiDimArray[0, 0];
        GameObject quad2A = QuadCoordinatesMultiDimArray[1, 0];
        GameObject quad3A = QuadCoordinatesMultiDimArray[2, 0];

        GameObject quad1B = QuadCoordinatesMultiDimArray[0, 1];
        GameObject quad2B = QuadCoordinatesMultiDimArray[1, 1];
        GameObject quad3B = QuadCoordinatesMultiDimArray[2, 1];

        GameObject quad1C = QuadCoordinatesMultiDimArray[0, 2];
        GameObject quad2C = QuadCoordinatesMultiDimArray[1, 2];
        GameObject quad3C = QuadCoordinatesMultiDimArray[2, 2];

        GameObject quad1D = QuadCoordinatesMultiDimArray[0, 3];
        GameObject quad2D = QuadCoordinatesMultiDimArray[1, 3];
        GameObject quad3D = QuadCoordinatesMultiDimArray[2, 3];

        ////// METOD SOM KOLLAR SIDA 1 /////// 

        bool sideOne = false;


        if (quad1A.tag == "1A")    //   H�r �r or- tecken om de beh�vs:  ||  
        {
            if (quad2A.tag == "2A")
            {
                if (quad3A.tag == "3A")
                {
                    sideOne = true;
                }
            }
        }

        else if (quad1A.tag == "1B")
        {
            if (quad2A.tag == "2B")
            {
                if (quad3A.tag == "3B")
                {
                    sideOne = true;
                }
            }
        }

        else if (quad1A.tag == "1C")
        {
            if (quad2A.tag == "2C")
            {
                if (quad3A.tag == "3C")
                {
                    sideOne = true;
                }
            }
        }

        else if (quad1A.tag == "1D")
        {
            if (quad2A.tag == "2D")
            {
                if (quad3A.tag == "3D")
                {
                    sideOne = true;
                }
            }
        }



        ////// METOD SOM KOLLAR SIDA 2 /////// 


        bool sideTwo = false;


        if (quad1B.tag == "1A")
        {
            if (quad2B.tag == "2A")
            {
                if (quad3B.tag == "3A")
                {
                    sideTwo = true;
                }
            }
        }

        else if (quad1B.tag == "1B")
        {
            if (quad2B.tag == "2B")
            {
                if (quad3B.tag == "3B")
                {
                    sideTwo = true;
                }
            }
        }

        else if (quad1B.tag == "1C")
        {
            if (quad2B.tag == "2C")
            {
                if (quad3B.tag == "3C")
                {
                    sideTwo = true;
                }
            }
        }

        else if (quad1B.tag == "1D")
        {
            if (quad2B.tag == "2D")
            {
                if (quad3B.tag == "3D")
                {
                    sideTwo = true;
                }
            }
        }


        ////// METOD SOM KOLLAR SIDA 3 /////// 


        bool sideThree = false;


        if (quad1C.tag == "1A")
        {
            if (quad2C.tag == "2A")
            {
                if (quad3C.tag == "3A")
                {
                    sideThree = true;
                }
            }
        }

        else if (quad1C.tag == "1B")
        {
            if (quad2C.tag == "2B")
            {
                if (quad3C.tag == "3B")
                {
                    sideThree = true;
                }
            }
        }

        else if (quad1C.tag == "1C")
        {
            if (quad2C.tag == "2C")
            {
                if (quad3C.tag == "3C")
                {
                    sideThree = true;
                }
            }
        }

        else if (quad1C.tag == "1D")
        {
            if (quad2C.tag == "2D")
            {
                if (quad3C.tag == "3D")
                {
                    sideThree = true;
                }
            }
        }

        ////// METOD SOM KOLLAR SIDA 4 /////// 


        bool sideFour = false;


        if (quad1D.tag == "1A")
        {
            if (quad2D.tag == "2A")
            {
                if (quad3D.tag == "3A")
                {
                    sideFour = true;
                }
            }
        }

        else if (quad1D.tag == "1B")
        {
            if (quad2D.tag == "2B")
            {
                if (quad3D.tag == "3B")
                {
                    sideFour = true;
                }
            }
        }

        else if (quad1D.tag == "1C")
        {
            if (quad2D.tag == "2C")
            {
                if (quad3D.tag == "3C")
                {
                    sideFour = true;
                }
            }
        }

        else if (quad1D.tag == "1D")
        {
            if (quad2D.tag == "2D")
            {
                if (quad3D.tag == "3D")
                {
                    sideFour = true;
                }
            }
        }


        if (sideOne && sideTwo && sideThree && sideFour)
        {
            SceneManager.LoadSceneAsync(4);
        }



        Debug.Log("Funkar"); // Genom att l�gga Debug h�r beh�ver vi inte klara pusslet f�r att se om denna funktion k�rs utan kollar kontinuerligt fr�n f�rsta shuffle



    }



}
