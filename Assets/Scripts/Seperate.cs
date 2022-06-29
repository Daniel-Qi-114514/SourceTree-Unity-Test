using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seperate : MonoBehaviour
{
    public float distance;//位移距离
    public float speed;//速度
    private Vector3 targetpos;//终点坐标
    private Vector3 startpos;//起点坐标
    private Vector3 offset;//偏移量
    private int x=2;
    // Start is called before the first frame update
    void Start()
    {
        startpos = gameObject.transform.position;
        offset = new Vector3(0, 0, distance);
        targetpos = startpos + offset;
    }
    void Update()
    {
        Ctrl(x);
    }

    // Update is called once per frame
    public void Sep()
    {
        transform.position = Vector3.MoveTowards(targetpos, startpos, speed * Time.deltaTime);
    }
    public void Back()
    {
        transform.position = Vector3.MoveTowards(startpos, targetpos, speed * Time.deltaTime);
    }
     public void Ctrl(int x)
    {
        if (x == 0)
        {
            //Debug.Log("Sep");
            Sep();
            x = 2;
        }
        else if (x == 1)
        {
            Debug.Log("Back");
            Back();
            x = 2;
        }
    } 
}
