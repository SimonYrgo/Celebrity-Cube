using UnityEngine;

public class ShipRotate : MonoBehaviour
{
    public float sensitivity = 10.0f; // hur snabbt ska jag rotera objektet? 

    private void OnMouseDrag() // Unity-metod som g�r att man kan rotera detta objekt scriptet sitetr p� n�r man klickar och h�ller nere LMB p� objektet
    {
        float xAxisRotaion = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.down, xAxisRotaion); // tranform syftar p� detta objektet .down �r att det ska rotera kring y-axeln, den andra parametern �r hur mycket grader rotation man ska apply
    }

}
