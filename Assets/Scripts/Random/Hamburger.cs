using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Hamburger : MonoBehaviour
{

    // h�gst upp skiver man oftast sina variabler (praxis) 


    public GameObject[,] RandomMultiDimArray = new GameObject[3, 4]; // vi g�r en slot i Unity,  och kollar om vi kan f� tillg�ng genom l�gga ett objekt med scriptet p� h�r i 


    public int lastRandomInt = 0;  // lagrar v�rdet av int r f�r att j�mf�ra s� man inte slumpar samma tal 2 ggr i rad. 

    /*
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Rotate(0, 45, 0);

            Shuffle();


        }
    }

    



    private void Shuffle() // bytt namn och funktion p� v�r metod
    {

        // collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[1]);
        // spelar nu ljudet i hamburgarLjud arrayet p� indexplats 1

        // int r = 0;



        int r = Random.Range(0, hamburgarLjud.Length);
        // i funktionen Random ger detta resulat randomv�rde mellan 0-2. hamburgarLjud.Length = 3 och �r taket
        // (min v�rde inkluderat, maxv�rde exkluderat)

        // dock men inte p� float..s� h�r g�r man d�r se nedan 
        // float r = Random.Range(0f, 3f);
        // (min v�rde inkluderat, maxv�rde inkluderat)

        r = duplicateSoundChecker(r, hamburgarLjud.Length); // duplicateSoundChecker b�de f�r r, �ndrar p� r om det beh�vs, och returnerar r
        // vi h�mtar metoden.duplicateSoundChecker matas med "r" och hamburgarLjud.Length



        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[r]);
        // spelar nu upp ett randomljud av de 3 som finns i arrayet

        // Debug.Log(hamburgarLjud[r]);
        // printar vilken arrayplats som spelar just nu via denna funktion
        // N�dv�ndigt att ha att kunna print debugga 

    }

    public int duplicateSoundChecker(int r, int length) // r = randomvariabeln i hamburgarscriptet, legnth = l�ngd p� hamburgarLjud
                                                    // int kan ocks� anv�ndas som funktion att returnera just en int med
    {

        while (r == lastRandomInt)  // kolla lastTandomInt (definerad h�gst upp).. >
                                    //  > ..om samma som r, slumpa om i s� fall. 
        {
            r = Random.Range(0, length); // vi anv�nder length = hamburgarljud-l�ngd f�r att kunna �ndra storlek p� array flexibelt
            Debug.Log(r);
        }

        lastRandomInt = r; // s�tt till samma som r
        return r; // returnera v�rdet i r 
    } 


    */

}
