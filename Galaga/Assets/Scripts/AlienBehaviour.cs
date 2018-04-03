using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Invoke("Attack", Random.Range(4, 20)); //Inicia o ataque em um tempo aleatório 
	}

	public void Attack (){
		Debug.Log ("Alien Atacando ...");
	}
}
