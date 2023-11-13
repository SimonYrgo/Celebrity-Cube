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
    GameObject[,] QuadCoordinatesMultiDimArray = new GameObject[3,4]; // ett multidimensionellt array (eg bara en två- axel grid?)  -  3 row stor, 4 column stor 
                                                                      // vi säger också att det bara kan vara GameObjects i den
                                                                      // ..ett sätt att säga t.ex i gång 3 hylla 4 lägger vi detta Gameobjectet t.ex? 

    public GameObject[] QuadGameObjectsArray; // vanligt array med Quad GameObjects befolkat genom slots  = 12 stycken slots/quads.Vi drog in alla quads som ska flyttas runt
                                              // verkar inte som man behöver göra en new-factory, om man gör en public grej som befolkas efter hand ute i Unity? 

    private int randomRow1, randomCol1, randomRow2, randomCol2; // skapar 4 ints  = koordinater i vår Multiarray. Måste klura ut hur man randomar dom utan att de upprepas ur rätt urval. 

    private CheckPuzzleDone solvedChecker; // skapar en variabel vi kan få tillgång till scriptet TheShuffle genom. Denna variable måste användas inuti en metod annars error = Att skapa en slot i Unity

    private void Start() // i start-metoden tror jag vi befolkar CubeCoordinatesMultiArrayet med objekt 
    {

        solvedChecker = new CheckPuzzleDone(); // vi skapade en referens variable på rad 22 nu måste vi skapa ett objekt av klassen - Detta är = att dra till en slot i Unity
        
        for (int i = 0; i < 3; i++) // loopa igenom (CubeCoordinates-multiarrayet?) 3 gånger för det som ska stå i rows
        {
            for(int j = 0; j < 4; j++) // loopa igenom (CubeCoordinates-multiarrayet?) 4 gånger för det som ska stå i columns
            {
                if (i == 0) // om indexplatsen för rows i CubeCoordinates-multiarrayet är 0 (dvs första rowen)
                {
                   QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[j]; // lägg GameObjectet på plats j i CubeCoordinatesArray på plats i och j i multiarrayet
                                                                               // frågan är bara hur den får coordinates från Gameobjectet och kan lägga i två axlar?  
                                                                               // just nu lägger man den bara på en plats iaf. 
                }

                else if (i == 1)                                                    // när översta rowen 0 är full befolkar vi row 1 med GameObjects
                {
                    QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[4 + j]; // på row 1, col 0-3, lägg GameObject 4-7 från CubeCoordinatesArray 
                }

                else if(i == 2)                                                     // när  row 1 är full befolkar vi row 2 med GameObjects
                {
                    QuadCoordinatesMultiDimArray[i, j] = QuadGameObjectsArray[8 + j]; // på row 2, col 0-3, lägg GameObject 8-11 från CubeCoordinatesArray 
                }
               

                
            }



        }


        RandomSwap();  //RandomSwap-funktionen som finns längre ner körs automatiskt vid start och blandar Quadarna

        

    }

    

    
    public void Swap(int row1, int col1, int row2, int col2)   // I denna funktion sker byten av Quadarnas rotation och transform  
                                                               // int row1 och col1 är för första quaden vi vill swappa corrdinates med, int row2 col2 för andra
    {

        GameObject quad1 = QuadCoordinatesMultiDimArray[row1, col1]; // detta GameObejct = den som ligger på platsen row1, col1 i vårt MultiArray
        
        GameObject quad2 = QuadCoordinatesMultiDimArray[row2, col2]; // detta GameObejct = den som ligger på platsen row2, col2 i vårt MultiArray
                                                                  // ..dvs den som vi vill byta plats med
        GameObject temporary = new GameObject();

        
        temporary.transform.position = quad1.transform.position; // skapar en tempory GameObject att spara position och rotation i
        temporary.transform.rotation = quad1.transform.rotation;

                                                                // Raderna nedan gör själva swappen på pos och rot

        quad1.transform.position = quad2.transform.position; // sätter quad 1:s position = quad 2:s position
        quad1.transform.rotation = quad2.transform.rotation; // sätter quad 1:s rotation = quad 2:s rotation

        quad2.transform.position = temporary.transform.position; // sätter quad 2:s position = temporary:s position eftersom quad1:s blev ändrad
        quad2.transform.rotation = temporary.transform.rotation; // sätter quad 2:s rotation = temporary:s rotation eftersom quad1:s blev ändrad


        QuadCoordinatesMultiDimArray[row1, col1] = quad2; // flyttar quad2 till denna plats i vårt array, men är inte den upptagen just nu?
                                                       // Får 2 GameObject plats på samma multiarray koordinater? varför måste vi inte göra temp?
                                                       // .. och ska inte quad2 stå före = tecknet? Nej för ett array kan inte bli överskrivet kanske?


        QuadCoordinatesMultiDimArray[row2, col2] = quad1;  // Nu har båda Quadarna bytt plats i Multiarrayet med. 

        Destroy(temporary); // Nu behöver vi inte temporary längre så vi Destroyar den, annars blir det fullt av meningslösa GameObjects i Unity

        // EventSystem.current.SetSelectedGameObject(null);


        solvedChecker.CheckPuzzleSolved(QuadCoordinatesMultiDimArray); // Nu kan vi kalla metoden StandAloneShuffle i TheShuffle scriptet och skicka med QuadCoordinatesMultiDimArray som argumnet




    }


    public void RandomSwap()   // I denna funktion sker Slumpade byten av Quadarnas rotation och transform  
                                                               // int row1 och col1 är för första quaden vi vill swappa corrdinates med, int row2 col2 för andra
    {
        for(int i = 0; i < 50; i++) // Denna funktionen blandar eg bara 2 slumpvisa quads, men jag kör den 50 ggr så blir det bra blandat. 
        {
            randomRow1 = Random.Range(0, 3);  // i funktionen Random ger detta resulat randomvärde mellan 0-2. min värde inkluderat, maxvärde exkluderat = 3 och är taket)
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

            GameObject quad1 = QuadCoordinatesMultiDimArray[randomRow1, randomCol1]; // detta GameObejct = den som ligger på platsen row1, col1 i vårt MultiArray

            GameObject quad2 = QuadCoordinatesMultiDimArray[randomRow2, randomCol2]; // detta GameObejct = den som ligger på platsen row2, col2 i vårt MultiArray
                                                                                     // ..dvs den som vi vill byta plats med
            GameObject temporary = new GameObject();


            temporary.transform.position = quad1.transform.position; // skapar en tempory GameObject att spara position och rotation i
            temporary.transform.rotation = quad1.transform.rotation;

            // Raderna nedan gör själva swappen på pos och rot

            quad1.transform.position = quad2.transform.position; // sätter quad 1:s position = quad 2:s position
            quad1.transform.rotation = quad2.transform.rotation; // sätter quad 1:s rotation = quad 2:s rotation

            quad2.transform.position = temporary.transform.position; // sätter quad 2:s position = temporary:s position eftersom quad1:s blev ändrad
            quad2.transform.rotation = temporary.transform.rotation; // sätter quad 2:s rotation = temporary:s rotation eftersom quad1:s blev ändrad


            QuadCoordinatesMultiDimArray[randomRow1, randomCol1] = quad2; // flyttar quad2 till denna plats i vårt array, men är inte den upptagen just nu?
                                                              // Får 2 GameObject plats på samma multiarray koordinater? varför måste vi inte göra temp?
                                                              // .. och ska inte quad2 stå före = tecknet? Nej för ett array kan inte bli överskrivet kanske?


            QuadCoordinatesMultiDimArray[randomRow2, randomCol2] = quad1;  // Nu har båda Quadarna bytt plats i Multiarrayet med. 

            Destroy(temporary); // Nu behöver vi inte temporary längre så vi Destroyar den, annars blir det fullt av meningslösa GameObjects i Unity

            // EventSystem.current.SetSelectedGameObject(null);


        }






    }





    /*

    private void ShuffleQuadGameObjectsArray() // Shufflar Ordning på QuadGameObjectsArray, men kommer eg ingen vart med det 
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
