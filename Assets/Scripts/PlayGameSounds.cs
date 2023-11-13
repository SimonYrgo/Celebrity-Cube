using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGameSounds : MonoBehaviour
{
   //  public AudioClip[] SpelLjud; //  = new AudioClip[3];

    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }


    /*

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<AudioSource>().PlayOneShot(SpelLjud[0]);  // p� detta spelobjektet  >
                                                                   // > .. h�mta Component Audiosource, och spela genom den ljudet lagrat p� indexplatsen i SpelLjudArrayet
                                                                   //(beh�ver inte speca gameObject om det g�ller detta objekt)

        }
    }

    */

    public void SpelaSpelLjud()
    {
        // source.clip = SpelLjud[0];
        source.Play();
    }


}
