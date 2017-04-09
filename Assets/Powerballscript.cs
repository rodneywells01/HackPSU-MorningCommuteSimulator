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
		//Debug.Log(totalpoints);
	}

	void OnCollisionEnter(Collision collision)
	{
		// Get points and add to total points.
		// Destroy collided object. 

		//This is the block
		Debug.Log(collision.collider.gameObject.name);

		//collision.col


		foreach (ContactPoint contact in collision.contacts)
		{
			
			//This is the sphere
			//Debug.Log(contact.thisCollider.gameObject);

			//This is the block
			//Debug.Log(contact.otherCollider.gameObject);

			if (contact.otherCollider.gameObject.tag == "red") {
				Debug.Log ("red block hit dawg");
				totalpoints += 10;
				Destroy (contact.otherCollider.gameObject);

			}
			else if (contact.otherCollider.gameObject.tag == "green") {
				Debug.Log ("green block hit dawg");
				totalpoints += 50;
				Destroy (contact.otherCollider.gameObject);
			}
			else if (contact.otherCollider.gameObject.tag == "blue") {
				Debug.Log ("blue block hit dawg");
				totalpoints += 100;
				Destroy (contact.otherCollider.gameObject);
			}


		}


		//if (collision.relativeVelocity.magnitude > 2)
		//	audio.Play();
	}
}
