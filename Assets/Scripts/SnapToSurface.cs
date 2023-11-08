using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SnapToSurface : MonoBehaviour
{

    int mask = ~(1 << 2); // måste ligga i klassen alla varibeler högst upp

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hitInfo = new RaycastHit();
        // hitInfo är en varibel av typern Raycasthit som vi lagrar datam av vad vi träffar i
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f, mask);
        // bool hit ä sann om Raycast träffar något. Den skjuter från sin mittpunkit rakt "framåt"
        // out hitIfo skickar ut datam om träffen till Raycasthitvariablen . 10f = läng på Raycast, 
        // mask är lagret den INTE ska träffa. Vet ej just nu vad det är den ine ska träffa
        // 
        if (hit)
        {
            float rotValue = transform.localRotation.eulerAngles.y;
            // rotValue skapas endast för att nedanstående fakta ska vara kortare
            transform.position = hitInfo.transform.position;
            // sätter först positionen på objektet Raycasten träffar till samma som den

            if (rotValue % 180 != 0) // KOllar om rotvalue remainder = 0 om sidor ej kvadristaska ska koiden ändå funka
            {
                transform.position -= transform.forward *(hitInfo.transform.localScale.x / 2 + 0.00001f);
            }

            else
            {
                transform.position -= transform.forward * (hitInfo.transform.localScale.z / 2 + 0.00001f);
            }

            // denna if sats gör att rotaion  = ojämnt nummner * 90 grader
            // Så ska vi sätta objektet enligt träff obhjektets x-värde i dens scale
            // annars så sätter vi enligt z-värdet
        }


    }

    
}
