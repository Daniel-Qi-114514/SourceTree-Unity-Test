using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp : MonoBehaviour
{
    public GameObject Medal;
    public void Sep()
    {
        Medal.SendMessage("Sep");
    }
    public void Back()
    {
        Medal.SendMessage("Back");
    }
}
