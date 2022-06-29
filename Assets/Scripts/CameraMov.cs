using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject target;
    private Vector3 offsetPosition;//相对位移
    private float distance;//摄像机离勋章距离
    public float Maxradius;//摄像机离勋章最大距离
    public float Minradius;//摄像机离勋章最小距离
    public float scrollSpeed;//缩放变化速度
    public float rotateSpeed;//视角旋转速度
    private bool isRotating = false;//判断是否旋转
    // Start is called before the first frame update
    void Start()
    {
        offsetPosition = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.LookAt(target.transform);
        transform.position = offsetPosition + target.transform.position;
        RotateView();//相机移动（实质是相机在固定半径的球面上移动）
        ScrollView();//视角缩放（实质是相机沿半径移动）
    }

    void RotateView()
    {
        if (Input.GetMouseButtonDown(0))//按下鼠标左键（对应数字0）进行相机移动
        {
            isRotating = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }
        if (isRotating)
        {
            transform.RotateAround(target.transform.position, target.transform.up, 
                rotateSpeed * Input.GetAxis("Mouse X"));
            Vector3 originalPos = transform.position;
            Quaternion originalRotation = transform.rotation;
            transform.RotateAround(target.transform.position, transform.right, 
                -rotateSpeed * Input.GetAxis("Mouse Y"));
            float x = transform.eulerAngles.x;
            if (x < 0 || x > 85)//限制摄像机活动范围
            {
                transform.position = originalPos;
                transform.rotation = originalRotation;
            }
        }
        offsetPosition = transform.position - target.transform.position;
    }

    void ScrollView()
    {
        distance = offsetPosition.magnitude;
        distance += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        distance=Mathf.Clamp(distance, Minradius, Maxradius);//限制距离
        offsetPosition = offsetPosition.normalized * distance;
        //.normalized为标准化向量，方向与LookAt相同
    }

}
