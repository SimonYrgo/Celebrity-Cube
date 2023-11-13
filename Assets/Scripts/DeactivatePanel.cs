using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePanel : MonoBehaviour
{

    public GameObject[] PanelThemeArray;
    
    private DropDown dropDownForPanel; // skapa sloten 



    private void Start()
    {
        
        dropDownForPanel = FindAnyObjectByType<DropDown>(); // Ist�llet f�r att "skapa Sloten": eftersom vi redan har skapat detta objekt g�r vi ist�llet en referens till den. Den s�ger hitta ett Objekt som heter DropDown i HELA Unity
        // Vi l�gger denna i startmetoden, annars m�ste vi g�ra detta varje g�ng vi vill anv�nda den ist�llet f�r att den a�r sparad

    }




    public void ActivateChosenPanel()
    {
        


        for (int i = 0; i < PanelThemeArray.Length; i++)
        {

            PanelThemeArray[i].SetActive(false); // Deaktivera  Gameobjektet som ligger p� [i]-platsen i Arrayet, Konstiogt nog verkar det siom kan man deaktivera Parentobjektet utan att childen st�ngs av

        }

        PanelThemeArray[dropDownForPanel.puzzleTheme].SetActive(true); // S�tt GameObjektet p� denna plats till Active


        
    }

  
}
