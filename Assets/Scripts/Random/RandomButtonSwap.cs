using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class RandomButtonSwap : MonoBehaviour
{
    SwapQuads randomSwapper; // skapar variablen swapper att spara referebs till ett SwapQuads script /metod i
    Button thisRandomButton; // skapar en variabel att referera till en Button med
    
    // private int randomRow1 , randomCol1, randomRow2, randomCol2; // skapar 4 ints  = koordinater i v�r Multiarray. M�ste klura ut hur man randomar dom utan att de upprepas ur r�tt urval. 



    


    // Start is called before the first frame update
    void Start()
    {
        /*
        randomRow1 = Random.Range(0, 3);  // i funktionen Random ger detta resulat randomv�rde mellan 0-2. min v�rde inkluderat, maxv�rde exkluderat = 3 och �r taket)
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
        thisRandomButton = GetComponent<Button>(); // s�tter this Button =  Button p� detta Objekt 
        randomSwapper = GameObject.FindObjectOfType<SwapQuads>(); // letar i hela Hierarkin efter ett GameObject som i sin tur inneh�ller ett " SwapQuads"-objekt" (v�rt script)
                                                                  // S�tter varibeln randomSwapper = detta script. Flera olika sorters find finns

        thisRandomButton.onClick.AddListener(() => { randomSwapper.RandomSwap(); });
        // n�r vi klickar p� Button:k�r RandomSwap metoden i randomSwapper-variablen
        // skicka med private int-v�rdena i randomRow1, randomCol1, randomRow2, randomCol2

       



        // thisRandomButton.onClick.AddListener(() => { Debug.Log("Hejja" + randomRow1);});

    }

        

    }
