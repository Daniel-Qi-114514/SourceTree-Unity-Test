using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spm : MonoBehaviour
{
    public GameObject[] component;
    public GameObject Star;
    private int i;
    public void Sep()
    {
        for (i = 0; i < component.Length; i++)
        {
            component[i].GetComponent<Seperate>().Ctrl(0);
            Star.GetComponent<Final>().Ctrl(0);
        }
        i = 0;
    }
    public void Back()
    {
        for (i = 0; i < component.Length; i++)
        {
            component[i].GetComponent<Seperate>().Ctrl(1);
            Star.GetComponent<Final>().Ctrl(1);
        }
        i = 0;
    }
}
