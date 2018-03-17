using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour {

	public Color[] damageColor;
	public int maxHits;
	protected int hitNumbers;


	// Use this for initialization
	void Start () {
        hitNumbers = 0;
	}
	
	private void OnCollisionExit2D(){

        GetComponent<Renderer>().material.color = damageColor[hitNumbers];
        hitNumbers++;
              
        if (hitNumbers >= maxHits) {

          Destroy(gameObject);
        } 

	}
}
