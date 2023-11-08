using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SnapToSurface : MonoBehaviour
{

    int mask = ~(1 << 2); // m�ste ligga i klassen alla varibeler h�gst upp

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hitInfo = new RaycastHit();
        // hitInfo �r en varibel av typern Raycasthit som vi lagrar datam av vad vi tr�ffar i
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f, mask);
        // bool hit � sann om Raycast tr�ffar n�got. Den skjuter fr�n sin mittpunkit rakt "fram�t"
        // out hitIfo skickar ut datam om tr�ffen till Raycasthitvariablen . 10f = l�ng p� Raycast, 
        // mask �r lagret den INTE ska tr�ffa. Vet ej just nu vad det �r den ine ska tr�ffa
        // 
        if (hit)
        {
            float rotValue = transform.localRotation.eulerAngles.y;
            // rotValue skapas endast f�r att nedanst�ende fakta ska vara kortare
            transform.position = hitInfo.transform.position;
            // s�tter f�rst positionen p� objektet Raycasten tr�ffar till samma som den

            if (rotValue % 180 != 0) // KOllar om rotvalue remainder = 0 om sidor ej kvadristaska ska koiden �nd� funka
            {
                transform.position -= transform.forward *(hitInfo.transform.localScale.x / 2 + 0.00001f);
            }

            else
            {
                transform.position -= transform.forward * (hitInfo.transform.localScale.z / 2 + 0.00001f);
            }

            // denna if sats g�r att rotaion  = oj�mnt nummner * 90 grader
            // S� ska vi s�tta objektet enligt tr�ff obhjektets x-v�rde i dens scale
            // annars s� s�tter vi enligt z-v�rdet
        }


    }

    
}
