using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{

    public int puzzleTheme;

    private DeactivatePanel deactivatePanel; // skapa sloten  

    private void Start()
    {

        deactivatePanel = FindAnyObjectByType<DeactivatePanel>(); // Istället för att "skapa Sloten": eftersom vi redan har skapat detta objekt gör vi istället en referens till den. Den säger hitta ett Objekt som heter DropDown i HELA Unity
        // Vi lägger denna i startmetoden, annars måste vi göra detta varje gång vi vill använda den istället för att den aär sparad

    }




    public void HandleInputData(int val)
    {

        if (val == 0)
        {
            puzzleTheme = 0;
        }

        if (val == 1)
        {
            puzzleTheme = 1;
        }

        if (val == 2) 
        {
            puzzleTheme = 2;
        }

        if (val == 3)
        {
            puzzleTheme = 3;
        }


        deactivatePanel.ActivateChosenPanel();

    }
}
