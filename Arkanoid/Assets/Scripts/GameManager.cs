using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject paddle;
    public GameObject specialItemPrefab;
    public int specialItemInterval;
    public Text scorePanel;

    private int totalPoints = 0;

	// Use this for initialization
	void Start () {
        Invoke("CreateSpecialItem", Random.Range(2, 8));
	}
	
	private void CreateSpecialItem() {
        GameObject specialItemTemp = Instantiate<GameObject>(specialItemPrefab);
        specialItemTemp.transform.position = new Vector2(UnityEngine.Random.Range(-5, 5), UnityEngine.Random.Range(-3, 3));
    }

    public void GameOver() {
        SceneManager.LoadScene("Scenes/GameOver", LoadSceneMode.Single);
    }

    public void onSpecialItemCollision() {
        Vector2 paddleCurrentSize = paddle.GetComponent<SpriteRenderer>().size;
        paddleCurrentSize.x += 1;

        paddle.GetComponent<SpriteRenderer>().size = paddleCurrentSize;
        paddle.GetComponent<BoxCollider2D>().size = paddleCurrentSize;

        Invoke("CreateSpecialItem", Random.Range(2, 8));
    }

    public void onBallHit(Collider2D collider) {
        if (collider.tag == "Wall") {
            addPoint(5);
        } else if (collider.tag == "Brick") {
            addPoint(15);
        } else if (collider.tag == "SpecialItem") {
            onSpecialItemCollision();
            Destroy(collider.gameObject);
        } else if (collider.name == "Floor") {
            GameOver();
        }

    }

    protected void addPoint (int point) {
        totalPoints += point;
        scorePanel.text = totalPoints.ToString();
    }
    
}
