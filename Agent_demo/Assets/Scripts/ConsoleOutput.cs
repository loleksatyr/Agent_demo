using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConsoleOutput : MonoBehaviour
{
    [SerializeField] Text Output;
    public void CreateText() {
        for (int i = 1; i < 100; i++)
        {

             if (i % 3 == 0 && i % 5 == 0)
             {
                 Output.text += " " + i + " Marco Polo";
             }
            
            else if (i % 3 == 0)
            {
                Output.text += " " + i + " Marco";
            }
            else if (i % 5 == 0)
            {
                Output.text += " " + i + " Polo";
            }
            else
            {
                Output.text += " " + i;
            }
        }
    }
    private void Start()
    {
        Output.text = "";
    }
    private void Update()
    {
       
    }
}
