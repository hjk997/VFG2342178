using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        Debug.Log(keyHorizontal.ToString());
        Debug.Log(keyVertical.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
