
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
//using static System.Net.Mime.MediaTypeNames;

public class HideButton : MonoBehaviour // , IPointerEnterHandler, IPointerExitHandler
{
  


    // public GameObject targetButton;

    void Start()

    {
        // gameObject.GetComponent<Button>().colors.normalColor.a = 
        //targetButton.SetActive(false);
    }

    void OnMouseOver()
    {
        // gameObject.GetComponent<Image>().enabled = true;
        Debug.Log("Entered");
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        // gameObject.GetComponent<Image>().enabled = false;
        Debug.Log("Exited");
    }





    /*

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().enabled = true;
        Debug.Log("Entering");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // targetButton.SetActive(false);
        Debug.Log("Exiting");


    }

    */



}
