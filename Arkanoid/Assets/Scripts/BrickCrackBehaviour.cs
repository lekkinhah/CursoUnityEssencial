using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCrackBehaviour : MonoBehaviour {

    public Sprite[] spriteList;
    public int maxHits;
    protected int hitNumbers;


    // Use this for initialization
    void Start()
    {
        hitNumbers = 0;
    }

    private void OnCollisionExit2D()
    {

        hitNumbers++;

        if (hitNumbers >= maxHits)
        {

            Destroy(gameObject);
        } else {
            GetComponent<SpriteRenderer>().sprite = spriteList[hitNumbers];
        }

    }
}
