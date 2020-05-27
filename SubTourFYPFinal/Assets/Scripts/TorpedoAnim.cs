using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TorpedoAnim : MonoBehaviour
{
    public Animator anim;
    public SteamVR_TrackedObject trackedObject = null;
    public SteamVR_Controller.Device device;

    void awake() 
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            anim.Play("torpedo");
        }
    }
}
