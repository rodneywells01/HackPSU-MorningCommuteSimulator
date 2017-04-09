using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlescript : MonoBehaviour {

    // Use this for initialization
    Rigidbody myrb;

    void Start () {
        myrb = GetComponent<Rigidbody>();
        //CollisionDetectionMode.ContinuousDynamic;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name.Contains("Ball"))
        {            
            GameObject entityhit = collision.gameObject;
            Rigidbody body = entityhit.GetComponent<Rigidbody>();
            body.AddForce(myrb.velocity * -100);
            Debug.Log("Hit!");
            //body.AddForce()
        }

    }
}
