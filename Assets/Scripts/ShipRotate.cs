using UnityEngine;

public class ShipRotate : MonoBehaviour
{
    public float sensitivity = 10.0f; // hur snabbt ska jag rotera objektet? 

    private void OnMouseDrag() // Unity-metod som gör att man kan rotera detta objekt scriptet sitetr på när man klickar och håller nere LMB på objektet
    {
        float xAxisRotaion = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.down, xAxisRotaion); // tranform syftar på detta objektet .down är att det ska rotera kring y-axeln, den andra parametern är hur mycket grader rotation man ska apply
    }

}
