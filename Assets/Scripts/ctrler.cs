using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrler : MonoBehaviour
{
    public GameObject Sepmedal;//分离体
    public GameObject Medal;//完全体
    private Spm spm;

    private void Start()
    {
        spm = Sepmedal.transform.GetChild(0).GetComponent<Spm>();
    }
    public void Seperate()//一个控制分离
    {
        Medal.SetActive(false);
        Sepmedal.SetActive(true);
        if (Sepmedal.activeSelf)
        {
            spm.Sep();
        }
    }
    public void Back()
    {
        spm.Back();
        Medal.SetActive(true);
        if (Sepmedal.activeSelf)
        {
            Sepmedal.SetActive(false);
        }
    }
}
