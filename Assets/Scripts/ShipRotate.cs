using UnityEngine;

public class ShipRotate : MonoBehaviour
{
    public float sensitivity = 10.0f; // hur snabbt ska jag rotera objektet? 

    public AudioSource RotateCubeLjud;
    


    private void Start()
    {
        RotateCubeLjud = GetComponent<AudioSource>();
    }


    bool playingTurningSound = false;

    bool released = true;

    Quaternion rotation;

    private void OnMouseDown()
    {
        rotation = transform.rotation;
    }

    private void OnMouseDrag() // Unity-metod som g�r att man kan rotera detta objekt scriptet sitetr p� n�r man klickar och h�ller nere LMB p� objektet
    {
        float xAxisRotaion = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.down, xAxisRotaion); // tranform syftar p� detta objektet .down �r att det ska rotera kring y-axeln, den andra parametern �r hur mycket grader rotation man ska apply
        if(rotation != transform.rotation)
        {
            playingTurningSound = true;
            RotateCubeSound();
        }

    }

    private void OnMouseUp() 
    {
        playingTurningSound = false;
        RotateCubeSound();

    }

    void RotateCubeSound ()
    {
        if (playingTurningSound && released)
        {
            RotateCubeLjud.loop = true; // s�tter p� loopen till AudioClipet
            released = false;
            // RotateCubeLjud.clip = sound.SpelLjud[1];
            RotateCubeLjud.Play();
        }

        if (!playingTurningSound && !released) 
        {
            RotateCubeLjud.loop = false; // st�ng av looopen
            released = true;
        }
        
    }

}
