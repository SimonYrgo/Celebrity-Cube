using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Hamburger : MonoBehaviour
{

    // högst upp skiver man oftast sina variabler (praxis) 


    public GameObject[,] RandomMultiDimArray = new GameObject[3, 4]; // vi gör en slot i Unity,  och kollar om vi kan få tillgång genom lägga ett objekt med scriptet på här i 


    public int lastRandomInt = 0;  // lagrar värdet av int r för att jämföra så man inte slumpar samma tal 2 ggr i rad. 

    /*
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Rotate(0, 45, 0);

            Shuffle();


        }
    }

    



    private void Shuffle() // bytt namn och funktion på vår metod
    {

        // collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[1]);
        // spelar nu ljudet i hamburgarLjud arrayet på indexplats 1

        // int r = 0;



        int r = Random.Range(0, hamburgarLjud.Length);
        // i funktionen Random ger detta resulat randomvärde mellan 0-2. hamburgarLjud.Length = 3 och är taket
        // (min värde inkluderat, maxvärde exkluderat)

        // dock men inte på float..så här gör man där se nedan 
        // float r = Random.Range(0f, 3f);
        // (min värde inkluderat, maxvärde inkluderat)

        r = duplicateSoundChecker(r, hamburgarLjud.Length); // duplicateSoundChecker både får r, ändrar på r om det behövs, och returnerar r
        // vi hämtar metoden.duplicateSoundChecker matas med "r" och hamburgarLjud.Length



        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[r]);
        // spelar nu upp ett randomljud av de 3 som finns i arrayet

        // Debug.Log(hamburgarLjud[r]);
        // printar vilken arrayplats som spelar just nu via denna funktion
        // Nödvändigt att ha att kunna print debugga 

    }

    public int duplicateSoundChecker(int r, int length) // r = randomvariabeln i hamburgarscriptet, legnth = längd på hamburgarLjud
                                                    // int kan också användas som funktion att returnera just en int med
    {

        while (r == lastRandomInt)  // kolla lastTandomInt (definerad högst upp).. >
                                    //  > ..om samma som r, slumpa om i så fall. 
        {
            r = Random.Range(0, length); // vi använder length = hamburgarljud-längd för att kunna ändra storlek på array flexibelt
            Debug.Log(r);
        }

        lastRandomInt = r; // sätt till samma som r
        return r; // returnera värdet i r 
    } 


    */

}
