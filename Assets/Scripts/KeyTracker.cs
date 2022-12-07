using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTracker : MonoBehaviour
{
    public theDoor door;
    public Text keysLeft;
    void Start()
    {
        keysLeft.text = "Keys Collected: " + door.keysCollected.ToString() + "/5";
    }

    
    void Update()
    {
        keysLeft.text = "Keys Collected: " + door.keysCollected.ToString() + "/5";
    }
}
