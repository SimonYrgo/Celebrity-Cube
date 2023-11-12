using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{

   public int puzzleTheme;
   public void HandleInputData(int val)
    {
        if (val == 0)
        {
            puzzleTheme = 1;
        }

        if (val == 1) 
        {
            puzzleTheme = 2;
        }

        if (val == 2)
        {
            puzzleTheme = 3;
        }
    }
}
