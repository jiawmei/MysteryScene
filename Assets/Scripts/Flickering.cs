using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour
{
    
    

    public new Light light;
    public float minIntensity = 10f;
    public float maxIntensity = 50f;
    
    

    void Start()
    {
       
        if (light == null)
        {
            light = GetComponent<Light>();
        }
    }

    void Update()
    {
        light.intensity = Random.Range(minIntensity, maxIntensity);
    }
}
    