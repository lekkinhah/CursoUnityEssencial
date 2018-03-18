using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	public float startSpeed;


	// Use this for initialization
	void Start () {
        //GetComponent<Rigidbody2D>().velocity = (Vector2.up+Vector2.right)*startSpeed;

    }

    private void Update() {

        if (GetComponent<Rigidbody2D>().velocity.y == 0f) {
            Vector2 currentPosition = transform.position; //Posição inicial da bola
            Vector2 positionPaddle = GameObject.Find("Paddle").transform.position; //Posição do paddle
            currentPosition.x = positionPaddle.x;
            GetComponent<Rigidbody2D>().MovePosition(currentPosition);
            if (Input.GetKey(KeyCode.Space)) {
                Debug.Log("start");
                StartBall();
            }
        }

              
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

    void StartBall() {
        GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * startSpeed;
    }

    
}
