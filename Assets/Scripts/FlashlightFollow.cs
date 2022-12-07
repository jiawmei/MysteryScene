using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightFollow : MonoBehaviour
{
    public bool lightOn = false;
    public GameObject lightSource;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (lightOn == false && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(true);
                lightOn = true;
                StartCoroutine(FailSafe());
            }
            if(lightOn == true && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(false);
                lightOn = false;
                StartCoroutine(FailSafe());
            }
        }

    }
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}
