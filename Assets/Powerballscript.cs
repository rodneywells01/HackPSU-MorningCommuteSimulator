using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerballscript : MonoBehaviour {

	public int totalpoints; 

	// Use this for initialization
	void Start () {
		totalpoints = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		// Check to see if hitting something 
		// If hitting, get point value of object and add to your points. Destroy hit object. 
	}

	void OnCollisionEnter(Collision collision)
	{
		// Get points and add to total points.
		// Destroy collided object. 

		collision.collider.gameObject.name;

		foreach (ContactPoint contact in collision.contacts)
		{
			contact.thisCollider.gameObjec
		}

		if (collision.relativeVelocity.magnitude > 2)
			audio.Play();
	}
}
