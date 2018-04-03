using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehaviour : MonoBehaviour {

	public float speed;
	public int screenLimit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 currentPosition = transform.position;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			currentPosition.x -= speed;
			//Debug.Log ("left");
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			currentPosition.x += speed;	
			//Debug.Log ("right");
		}

		if (currentPosition.x < screenLimit && currentPosition.x > -screenLimit ){
			GetComponent<Rigidbody2D> ().MovePosition (currentPosition);
		}


	}




}
