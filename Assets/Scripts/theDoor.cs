using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theDoor : MonoBehaviour
{
    public Animator door;
    public string doorAction = "open";
    public int keysCollected = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }

    public void addOneKey()
    {
        keysCollected += 1;
    }
    public void totalKeys()
    {
        Debug.Log(keysCollected);
    }

    public void openDoor()
    {
        door.Play(doorAction, 0, 0.0f);
    }
}
