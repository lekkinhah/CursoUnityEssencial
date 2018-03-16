using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour {

	public Color[] damageColor;
	public int maxHits;
	protected int hitNumbers;


	// Use this for initialization
	void Start () {
		hitNumbers =0
	}
	
	void OnCollisionExit2D(){
		
	}
}
