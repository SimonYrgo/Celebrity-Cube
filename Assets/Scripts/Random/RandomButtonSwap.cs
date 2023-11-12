using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class RandomButtonSwap : MonoBehaviour
{
    SwapQuads randomSwapper; // skapar variablen swapper att spara referebs till ett SwapQuads script /metod i
    Button thisRandomButton; // skapar en variabel att referera till en Button med
    
    // private int randomRow1 , randomCol1, randomRow2, randomCol2; // skapar 4 ints  = koordinater i vår Multiarray. Måste klura ut hur man randomar dom utan att de upprepas ur rätt urval. 



    


    // Start is called before the first frame update
    void Start()
    {
        /*
        randomRow1 = Random.Range(0, 3);  // i funktionen Random ger detta resulat randomvärde mellan 0-2. min värde inkluderat, maxvärde exkluderat = 3 och är taket)
        randomCol1 = Random.Range(0, 4);
        randomRow2 = Random.Range(0, 3);
        randomCol2 = Random.Range(0, 4);

        if(randomRow1 == randomRow2 && randomCol1 == randomCol2 )
        {
            randomRow1 = Random.Range(0, 3);
            randomCol1 = Random.Range(0, 4);
            randomRow2 = Random.Range(0, 3);
            randomCol2 = Random.Range(0, 4);
        }


        

        // Debug.Log("Hejja" + randomRow1);

        */
        thisRandomButton = GetComponent<Button>(); // sätter this Button =  Button på detta Objekt 
        randomSwapper = GameObject.FindObjectOfType<SwapQuads>(); // letar i hela Hierarkin efter ett GameObject som i sin tur innehåller ett " SwapQuads"-objekt" (vårt script)
                                                                  // Sätter varibeln randomSwapper = detta script. Flera olika sorters find finns

        thisRandomButton.onClick.AddListener(() => { randomSwapper.RandomSwap(); });
        // när vi klickar på Button:kör RandomSwap metoden i randomSwapper-variablen
        // skicka med private int-värdena i randomRow1, randomCol1, randomRow2, randomCol2

       



        // thisRandomButton.onClick.AddListener(() => { Debug.Log("Hejja" + randomRow1);});

    }

        

    }
