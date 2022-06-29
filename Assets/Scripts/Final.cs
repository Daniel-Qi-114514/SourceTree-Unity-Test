using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject medal;//完全体
    public GameObject Sepmedal;//分离体
    public float distance;
    public float speed;
    private Vector3 targetpos;
    private Vector3 startpos;
    private Vector3 offset;
    private int x = 2;
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
            Debug.Log("Sep");
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
