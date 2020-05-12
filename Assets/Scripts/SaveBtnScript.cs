using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveBtnScript : MonoBehaviour
{
    public Transform tr;
    public GameObject cube;

    private String saveTime;

    public Text SaveLogText;

    // Start is called before the first frame update
    void Start(){
        cube = GameObject.Find("CubePlayer");
        tr = cube.GetComponent<Transform>();

        float x_Point;
        float y_Point;
        float z_Point;

        //tr = GetComponent<Transform>();
        
        saveTime = PlayerPrefs.GetString("SaveTime");
        x_Point = PlayerPrefs.GetFloat("x_Point");
        y_Point = PlayerPrefs.GetFloat("y_Point");
        z_Point = PlayerPrefs.GetFloat("z_Point");

        if (saveTime != null)
        {
            SaveLogText.text = saveTime;
            Vector3 pos = new Vector3(x_Point, y_Point, z_Point);
            tr.transform.position = pos;
            Debug.Log("x" + x_Point.ToString());
            Debug.Log("y" + y_Point.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveBtnClicked()
    {
        Vector3 pos;

        pos = tr.transform.position;
        Debug.Log("Save Btn");

        saveTime = "마지막 저장시간 :\n" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        SaveLogText.text = saveTime;

        Debug.Log("x: " + pos.x.ToString() + "y: " + pos.y.ToString() + "z: " + pos.z.ToString());
        PlayerPrefs.SetString("SaveTime", saveTime);
        PlayerPrefs.SetFloat("x_Point", pos.x);
        PlayerPrefs.SetFloat("y_Point", pos.y);
        PlayerPrefs.SetFloat("z_Point", pos.z);
    }
}
