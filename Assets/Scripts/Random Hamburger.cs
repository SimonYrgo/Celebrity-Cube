using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
using Unity.VisualScripting;

public class Shuffle : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}








public class Hamburger : MonoBehaviour
{

    // h�gst upp skiver man oftast sina variabler (praxis) 

    public AudioClip clip_1;
    public AudioClip clip_2;
    public AudioClip clip_3;

    public TextManager textManager;

    public AudioClip[] hamburgarLjud = new AudioClip[3];


    private void Start()
    {
        // i Start voiden skriver man det som ska vara klart till andra funkioner i scriptet att jobba med

        for (int i = 0; i < hamburgarLjud.Length; i++)
        {
            if (i == 0)
            {
                hamburgarLjud[i] = clip_1;
            }
            else if (i == 1)
            {
                hamburgarLjud[i] = clip_2;
            }
            else if (i == 2)
            {
                hamburgarLjud[i] = clip_3;
            }


        }
    }



    private void OnTriggerEnter(Collider collision) // h�mta collidern som g�r in i min trigger
    {
        // collision.gameObject.GetComponent<AudioSource>().PlayOneShot(clip_1);
        // andra s�ttet att spela upp 

        // collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[1]);
        // spelar nu ljudet i hamburgarLjud arrayet p� indexplats 1

        // int r = 0;



        int r = Random.Range(0, hamburgarLjud.Length);
        // i funktionen Random ger detta resulat randomv�rde mellan 0-2. hamburgarLjud.Length = 3 och �r taket
        // (min v�rde inkluderat, maxv�rde exkluderat)

        // dock men inte p� float..s� h�r g�r man d�r se nedan 
        // float r = Random.Range(0f, 3f);
        // (min v�rde inkluderat, maxv�rde inkluderat)

        r = collision.gameObject.GetComponent<CharacterMove>().duplicateSoundChecker(r, hamburgarLjud.Length);
        // GetComponent<> pilar referar till vilken komponent, () = eftersom GetComponent �r metod,
        // vi h�mtar metoden.duplicateSoundChecker i CharacterMove scriptet och matar med "r" och hamburgarLjud.Length



        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(hamburgarLjud[r]);
        // spelar nu upp ett randomljud av de 3 som finns i arrayet

        // Debug.Log(hamburgarLjud[r]);
        // printar vilken arrayplats som spelar just nu via denna funktion
        // N�dv�ndigt att ha att kunna print debugga 


        textManager.playerHeal(2);
        Destroy(gameObject);


    }



}
*/
