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

    private void OnMouseDrag() // Unity-metod som gör att man kan rotera detta objekt scriptet sitetr på när man klickar och håller nere LMB på objektet
    {
        float xAxisRotaion = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.down, xAxisRotaion); // tranform syftar på detta objektet .down är att det ska rotera kring y-axeln, den andra parametern är hur mycket grader rotation man ska apply
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
            RotateCubeLjud.loop = true; // sätter på loopen till AudioClipet
            released = false;
            // RotateCubeLjud.clip = sound.SpelLjud[1];
            RotateCubeLjud.Play();
        }

        if (!playingTurningSound && !released) 
        {
            RotateCubeLjud.loop = false; // stäng av looopen
            released = true;
        }
        
    }

}
