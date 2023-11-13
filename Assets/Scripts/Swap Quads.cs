using JetBrains.Annotations;
// using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SwapQuads : MonoBehaviour
{
    GameObject[,] QuadCoordinatesMultiDimArray = new GameObject[3,4]; // ett multidimensionellt array (eg bara en tv�- axel grid?)  -  3 row stor, 4 column stor 
                                                                      // vi s�ger ocks� att det bara kan vara GameObjects i den
                                                                      // ..ett s�tt att s�ga t.ex i g�ng 3 hylla 4 l�gger vi detta Gameobjectet t.ex? 

    public GameObject[] QuadGameObjectsArray; // vanligt array med Quad GameObjects befolkat genom slots  = 12 stycken slots/quads.Vi drog in alla quads som ska flyttas runt
                                              // verkar inte som man beh�ver g�ra en new-factory, om man g�r en public grej som befolkas efter hand ute i Unity? 

    private int randomRow1, randomCol1, randomRow2, randomCol2; // skapar 4 ints  = koordinater i v�r Multiarray. M�ste klura ut hur man randomar dom utan att de upprepas ur r�tt urval. 

    private CheckPuzzleDone solvedChecker; // skapar en variabel vi kan f� tillg�ng till scriptet TheShuffle genom. Denna variable m�ste anv�ndas inuti en metod annars error = Att skapa en slot i Unity

    private void Start() // i start-metoden tror jag vi befolkar CubeCoordinatesMultiArrayet med objekt 
    {

        solvedChecker = new CheckPuzzleDone(); // vi skapade en referens variable p� rad 22 nu m�ste vi skapa ett objekt av klassen - Detta �r = att dra till en slot i Unity
        
        for (int i = 0; i < 3; i++) // loopa igenom (CubeCoordinates-multiarrayet?) 3 g�nger f�r det som ska st� i rows
        {
            for(int j = 0; j < 4; j++) // loopa igenom (CubeCoordinates-multiarrayet?) 4 g�nger f�r det som ska st� i columns
            {
                if (i == 0) // om indexplatsen f�r rows i CubeCoordinates-multiarrayet �r 0 (dvs f�rsta rowen)
                {
                   QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[j]; // l�gg GameObjectet p� plats j i CubeCoordinatesArray p� plats i och j i multiarrayet
                                                                               // fr�gan �r bara hur den f�r coordinates fr�n Gameobjectet och kan l�gga i tv� axlar?  
                                                                               // just nu l�gger man den bara p� en plats iaf. 
                }

                else if (i == 1)                                                    // n�r �versta rowen 0 �r full befolkar vi row 1 med GameObjects
                {
                    QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[4 + j]; // p� row 1, col 0-3, l�gg GameObject 4-7 fr�n CubeCoordinatesArray 
                }

                else if(i == 2)                                                     // n�r  row 1 �r full befolkar vi row 2 med GameObjects
                {
                    QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[8 + j]; // p� row 2, col 0-3, l�gg GameObject 8-11 fr�n CubeCoordinatesArray 
                }
               

                
            }



        }


        RandomSwap();  //RandomSwap-funktionen som finns l�ngre ner k�rs automatiskt vid start och blandar Quadarna

        

    }

    

    
    public void Swap(int row1, int col1, int row2, int col2)   // I denna funktion sker byten av Quadarnas rotation och transform  
                                                               // int row1 och col1 �r f�r f�rsta quaden vi vill swappa corrdinates med, int row2 col2 f�r andra
    {

        GameObject quad1 = QuadCoordinatesMultiDimArray[row1, col1]; // detta GameObejct = den som ligger p� platsen row1, col1 i v�rt MultiArray
        
        GameObject quad2 = QuadCoordinatesMultiDimArray[row2, col2]; // detta GameObejct = den som ligger p� platsen row2, col2 i v�rt MultiArray
                                                                  // ..dvs den som vi vill byta plats med
        GameObject temporary = new GameObject();

        
        temporary.transform.position = quad1.transform.position; // skapar en tempory GameObject att spara position och rotation i
        temporary.transform.rotation = quad1.transform.rotation;

                                                                // Raderna nedan g�r sj�lva swappen p� pos och rot

        quad1.transform.position = quad2.transform.position; // s�tter quad 1:s position = quad 2:s position
        quad1.transform.rotation = quad2.transform.rotation; // s�tter quad 1:s rotation = quad 2:s rotation

        quad2.transform.position = temporary.transform.position; // s�tter quad 2:s position = temporary:s position eftersom quad1:s blev �ndrad
        quad2.transform.rotation = temporary.transform.rotation; // s�tter quad 2:s rotation = temporary:s rotation eftersom quad1:s blev �ndrad


        QuadCoordinatesMultiDimArray[row1, col1] = quad2; // flyttar quad2 till denna plats i v�rt array, men �r inte den upptagen just nu?
                                                       // F�r 2 GameObject plats p� samma multiarray koordinater? varf�r m�ste vi inte g�ra temp?
                                                       // .. och ska inte quad2 st� f�re = tecknet? Nej f�r ett array kan inte bli �verskrivet kanske?


        QuadCoordinatesMultiDimArray[row2, col2] = quad1;  // Nu har b�da Quadarna bytt plats i Multiarrayet med. 

        Destroy(temporary); // Nu beh�ver vi inte temporary l�ngre s� vi Destroyar den, annars blir det fullt av meningsl�sa GameObjects i Unity

        // EventSystem.current.SetSelectedGameObject(null);


        solvedChecker.CheckPuzzleSolved(QuadCoordinatesMultiDimArray); // Nu kan vi kalla metoden StandAloneShuffle i TheShuffle scriptet och skicka med QuadCoordinatesMultiDimArray som argumnet




    }


    public void RandomSwap()   // I denna funktion sker Slumpade byten av Quadarnas rotation och transform  
                                                               // int row1 och col1 �r f�r f�rsta quaden vi vill swappa corrdinates med, int row2 col2 f�r andra
    {
        for(int i = 0; i < 50; i++) // Denna funktionen blandar eg bara 2 slumpvisa quads, men jag k�r den 50 ggr s� blir det bra blandat. 
        {
            randomRow1 = Random.Range(0, 3);  // i funktionen Random ger detta resulat randomv�rde mellan 0-2. min v�rde inkluderat, maxv�rde exkluderat = 3 och �r taket)
            randomCol1 = Random.Range(0, 4);
            randomRow2 = Random.Range(0, 3);
            randomCol2 = Random.Range(0, 4);

            if (randomRow1 == randomRow2 && randomCol1 == randomCol2)
            {
                randomRow1 = Random.Range(0, 3);
                randomCol1 = Random.Range(0, 4);
                randomRow2 = Random.Range(0, 3);
                randomCol2 = Random.Range(0, 4);
            }

            GameObject quad1 = QuadCoordinatesMultiDimArray[randomRow1, randomCol1]; // detta GameObejct = den som ligger p� platsen row1, col1 i v�rt MultiArray

            GameObject quad2 = QuadCoordinatesMultiDimArray[randomRow2, randomCol2]; // detta GameObejct = den som ligger p� platsen row2, col2 i v�rt MultiArray
                                                                                     // ..dvs den som vi vill byta plats med
            GameObject temporary = new GameObject();


            temporary.transform.position = quad1.transform.position; // skapar en tempory GameObject att spara position och rotation i
            temporary.transform.rotation = quad1.transform.rotation;

            // Raderna nedan g�r sj�lva swappen p� pos och rot

            quad1.transform.position = quad2.transform.position; // s�tter quad 1:s position = quad 2:s position
            quad1.transform.rotation = quad2.transform.rotation; // s�tter quad 1:s rotation = quad 2:s rotation

            quad2.transform.position = temporary.transform.position; // s�tter quad 2:s position = temporary:s position eftersom quad1:s blev �ndrad
            quad2.transform.rotation = temporary.transform.rotation; // s�tter quad 2:s rotation = temporary:s rotation eftersom quad1:s blev �ndrad


            QuadCoordinatesMultiDimArray[randomRow1, randomCol1] = quad2; // flyttar quad2 till denna plats i v�rt array, men �r inte den upptagen just nu?
                                                              // F�r 2 GameObject plats p� samma multiarray koordinater? varf�r m�ste vi inte g�ra temp?
                                                              // .. och ska inte quad2 st� f�re = tecknet? Nej f�r ett array kan inte bli �verskrivet kanske?


            QuadCoordinatesMultiDimArray[randomRow2, randomCol2] = quad1;  // Nu har b�da Quadarna bytt plats i Multiarrayet med. 

            Destroy(temporary); // Nu beh�ver vi inte temporary l�ngre s� vi Destroyar den, annars blir det fullt av meningsl�sa GameObjects i Unity

            // EventSystem.current.SetSelectedGameObject(null);


        }






    }





    /*

    private void ShuffleQuadGameObjectsArray() // Shufflar Ordning p� QuadGameObjectsArray, men kommer eg ingen vart med det 
    {

        for (int positionOfArray = 0; positionOfArray < QuadGameObjectsArray.Length; positionOfArray++)
        {
            GameObject obj = QuadGameObjectsArray[positionOfArray];
            int randomizeArray = Random.Range(0, positionOfArray);
            QuadGameObjectsArray[positionOfArray] = QuadGameObjectsArray[randomizeArray];
            QuadGameObjectsArray[randomizeArray] = obj;

            
        }

    }

        void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {

            ShuffleQuadGameObjectsArray();


        }
    }

    */
}
