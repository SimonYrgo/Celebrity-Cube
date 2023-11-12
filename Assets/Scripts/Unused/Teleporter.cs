//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 Position; // h�r kan man skriva in vart spelaren ska teleportera till 
    public Transform Player; // dra in din gubbe hit 
    public AudioClip clip; // slot du kan dra ett ljud till 
    private void OnTriggerEnter2D(Collider2D collision) // n�r spelaren g�r in i triggern 

    {
        Player.position = Position; // flytta spelaren till transformen i Position 
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(clip); // spelar ljudet i "clip" - sloten 
    }
}
