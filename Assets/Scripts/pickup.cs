using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform playerCameraTransform;
    public LayerMask theKeys;
    public LayerMask theDoor;
    public theDoor door;
    //public keys key;
    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float pickUpDistance = 3f;
            if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, theKeys))
            {
                if(raycastHit.transform.TryGetComponent(out keys key))
                {
                    key.pickedUp();
                    door.addOneKey();
                    door.totalKeys();
                }
            }
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit2, pickUpDistance, theDoor))
            {
                if (raycastHit2.transform.TryGetComponent(out theDoor door))
                {
                    if(door.keysCollected == 7)
                    {
                        door.destroyDoor();
                    }
                }
            }
        }
    }
}
