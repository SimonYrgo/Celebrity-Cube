using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSwap : MonoBehaviour
{
    SwapQuads swapper;
    Button thisButton;
    public int row1, col1, row2, col2;

    // Start is called before the first frame update
    void Start()
    {
        
        thisButton = GetComponent<Button>();
        swapper = GameObject.FindObjectOfType<SwapQuads>(); // letar i hela hierarkin, flera olika sorters find  finns
        thisButton.onClick.AddListener(() => { swapper.Swap(row1, col1, row2, col2); });


    }
}
