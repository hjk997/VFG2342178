using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnClick : MonoBehaviour
{
    
    public Transform tr;

    public float speed = 20;
    public bool go, right, left;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            Debug.Log("Up Btn");
            tr.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (left){
            Debug.Log("Left Btn");
            tr.Rotate(new Vector3(0, -50, 0) * Time.deltaTime);

        }
        if (right){
            Debug.Log("Right Btn");
            tr.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
        }
    }

    public void LeftBtnClickedUp()
    {
        left = false;
    }
    public void LeftBtnClickedDown()
    {
        left = true;
    }
    public void RightBtnClickedUp()
    {
        right = false;
    }
    public void RightBtnClickedDown()
    {
        right = true;
    }

    public void UpBtnClickedUp()
    {
        go = false;
    }

    public void UpBtnClickedDown()
    {
        go = true;
    }

    public void JumpBtnClicked()
    {
        Debug.Log("Jump Btn");
        Vector3 pos = new Vector3(0.0f, 13.0f, 0.0f);
        tr.transform.position = pos;
    }

}
