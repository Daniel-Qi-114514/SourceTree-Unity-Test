using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubOnOff : MonoBehaviour
{
    public GameObject Sub;//字幕框
    public GameObject Background;//字幕背景图片
    public int index=0;//计数器
    public void ChangeSub()
    {
        if (index == 0)//开启字幕
        {
            Sub.SetActive(true);
            Background.SetActive(true);
            index++;
        }
        else if(index == 1)//关闭字幕
        {
            Sub.SetActive(false);
            Background.SetActive(false);
            index = 0;
        }
    }
}
