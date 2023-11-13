using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{

    public int puzzleTheme;

    private DeactivatePanel deactivatePanel; // skapa sloten  

    private void Start()
    {

        deactivatePanel = FindAnyObjectByType<DeactivatePanel>(); // Ist�llet f�r att "skapa Sloten": eftersom vi redan har skapat detta objekt g�r vi ist�llet en referens till den. Den s�ger hitta ett Objekt som heter DropDown i HELA Unity
        // Vi l�gger denna i startmetoden, annars m�ste vi g�ra detta varje g�ng vi vill anv�nda den ist�llet f�r att den a�r sparad

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
