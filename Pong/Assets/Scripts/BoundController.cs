using UnityEngine;
using System.Collections;

public class BoundController : MonoBehaviour {

	//enemy transform
	public Transform enemy;

	public int enemyScore;
	public int playerScore;

	void Start(){
		enemyScore = 0;
		playerScore = 0;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Ball"){
			if(other.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0){
				enemyScore++;
			} else {
				playerScore++;
			}


			//Destroys other object
			Destroy(other.gameObject);

			//sets enemy's position back to original
			enemy.position = new Vector3(-6,0,0);
			//pauses game
			Time.timeScale = 0;
		}
	}
}
