using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePanel : MonoBehaviour
{

    public GameObject[] PanelThemeArray;
    
    private DropDown dropDownForPanel; // skapa sloten 



    private void Start()
    {
        
        dropDownForPanel = FindAnyObjectByType<DropDown>(); // Istället för att "skapa Sloten": eftersom vi redan har skapat detta objekt gör vi istället en referens till den. Den säger hitta ett Objekt som heter DropDown i HELA Unity
        // Vi lägger denna i startmetoden, annars måste vi göra detta varje gång vi vill använda den istället för att den aär sparad

    }




    public void ActivateChosenPanel()
    {
        


        for (int i = 0; i < PanelThemeArray.Length; i++)
        {

            PanelThemeArray[i].SetActive(false); // Deaktivera  Gameobjektet som ligger på [i]-platsen i Arrayet, Konstiogt nog verkar det siom kan man deaktivera Parentobjektet utan att childen stängs av

        }

        PanelThemeArray[dropDownForPanel.puzzleTheme].SetActive(true); // Sätt GameObjektet på denna plats till Active


        
    }

  
}
