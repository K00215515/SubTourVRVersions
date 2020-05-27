using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class ObjectPickup : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }


    void Update()
    {
        if (controller == null) return;

        // Change the ButtonMask to access other inputs
        if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger down");
        }

        if (controller.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger still down");
        }

        if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger released");
        }
    }

}
