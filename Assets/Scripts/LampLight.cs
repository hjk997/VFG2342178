using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour
{
    public GameObject sunLight;
    public ParticleSystem lampLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(sunLight.GetComponent<Transform>().rotation.eulerAngles.x);
        if (sunLight.GetComponent<Transform>().rotation.eulerAngles.x > 250)
        {
                lampLight.Stop();
            
        }
        else
        {
                lampLight.Play();
            
        }
    }
}
