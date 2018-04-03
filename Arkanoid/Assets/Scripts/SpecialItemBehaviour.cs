using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialItemBehaviour : MonoBehaviour {

    public GameManager gameManager;

    public void OnTriggerEnter2D(Collider2D collision) {
        gameManager.onSpecialItemCollision();
        Destroy(gameObject);
    }
}
