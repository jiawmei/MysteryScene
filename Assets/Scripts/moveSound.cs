using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSound : MonoBehaviour
{

    public AudioSource footsteps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}
