using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CallTyper: MonoBehaviour
{
    public Typer typerTest;
    // Update is called once per frame
    public void Type()
    {

        if (typerTest == null)
        {
            return;
        }
        typerTest.TyperEffect();
    }    
}


