using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickedUp()
    {
        Destroy(gameObject);
    }
}
