using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehaviour : MonoBehaviour {

	public float screenLimit;
	public float speed = 0.2f;
		
    float widthPaddle;

	// Use this for initialization
	void Start () {
		widthPaddle = GetComponent<SpriteRenderer> ().size.x; 
	}
	
	void Update () {
        Vector2 currentPosition = transform.position;

        if (Input.GetKey (KeyCode.LeftArrow)) {
            currentPosition.x -= speed;
           // Debug.Log ("left");
		} else if (Input.GetKey (KeyCode.RightArrow)) {
            currentPosition.x += speed;	
          //  Debug.Log ("right");
		}

		if (currentPosition.x < screenLimit-widthPaddle/2 && currentPosition.x > -(screenLimit - widthPaddle / 2)){
          //  Debug.Log("entrou no if de movimento");
           // transform.position = currentPosition;
			GetComponent<Rigidbody2D> ().MovePosition (currentPosition);
        }

	}
}
