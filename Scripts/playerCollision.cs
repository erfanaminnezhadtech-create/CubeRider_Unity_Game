using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			Debug.Log("Hi");
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
