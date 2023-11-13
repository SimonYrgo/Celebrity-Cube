using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonSwap : MonoBehaviour
{
    SwapQuads swapper; // skapar variablen swapper att spara ett SwapQuads script /metod i ? 
    Button thisButton; // skapar en variabel att refera till en Button med
    public int row1, col1, row2, col2; // skapar slots p� denna Buttonkanppen f�r 4 ints  = koordinater i v�r Multiarray. Vi matar in dessa i Unity och anv�nder nedan 


    PlayGameSounds playGameSounds;


    // Start is called before the first frame update
    void Start()
    {

        

        thisButton = GetComponent<Button>(); // this Button =  Button p� detta Objekt 
        swapper = GameObject.FindObjectOfType<SwapQuads>(); // letar i hela Hierarkin efter ett GameObject som i sin tur inneh�ller ett " SwapQuads"-objekt" (v�rt script)
                                                            // S�tter varibeln swapper = detta script. Flera olika sorters find finns

        playGameSounds = GameObject.FindObjectOfType<PlayGameSounds>(); // samma f�r objektet playGameSounds

        thisButton.onClick.AddListener(() => { swapper.Swap(row1, col1, row2, col2); playGameSounds.SpelaSpelLjud(); }); // n�r vi klickar p� Button:k�r Swap metoden i swapper-variablen
                                                                                         // skicka med public int-v�rdena i row1, col1, row2, col2, 
        

        // Kan jag l�gga till en metod till i samma? 


    }

    
    
}
