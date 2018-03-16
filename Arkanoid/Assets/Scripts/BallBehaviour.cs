using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	public float startSpeed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = (Vector2.up+Vector2.right)*startSpeed;
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log (collision.collider.name);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.name);

		if(other.name == "Floor"){
			Debug.Log ("GameOver");
		}
	}
}
