using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLoadScene : MonoBehaviour
{

    public DropDown dropDown;  // varf�r kan jag inte bara skriva Dropdown dropDown och f� tillg�ng,  ist�llet f�r att skapa slot ute i Unity? 


    /*
    void Start()
    {
        dropDown = GameObject.FindObjectOfType<DropDown>();
        
    }

    */


    int apansson;

    public void PlayGame()
    {

        // Debug.Log(dropDown.puzzleTheme);

        SceneManager.LoadSceneAsync(dropDown.puzzleTheme);
    }
}
