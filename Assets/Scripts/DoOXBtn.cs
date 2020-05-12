using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Text selectScript;
    bool isSelectSaveObject;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        selectScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelectSaveObject)
        {
            
        }
    }
}
