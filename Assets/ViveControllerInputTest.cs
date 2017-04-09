using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        
        if (name == "Controller (right)")
        {
            FixedJoint fx = gameObject.AddComponent<FixedJoint>();
            fx.breakForce = Mathf.Infinity;
            fx.breakTorque = Mathf.Infinity;

            fx.connectedBody = GameObject.Find("Paddle").GetComponent<Rigidbody>();
            Debug.Log("Got it!");
        }
        
    }

    // Update is called once per frame
    void Update () {
        // 1
        if (Controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + Controller.GetAxis());
        }

        // 2
        if (Controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " Trigger Press");
        }

        // 3
        if (Controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release");
        }

        // 4
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Press");

            GameObject powerball = GameObject.Find("Powerball");
            
            Rigidbody rb = powerball.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;

            GameObject camera = GameObject.Find("Camera (eye)");

            Vector3 adder = new Vector3(0f, .1f, -.7f);
            Vector3 startlocation = camera.transform.position + adder;
            powerball.transform.position = startlocation;
        }

        // 5
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Release");
        }
    }
}
