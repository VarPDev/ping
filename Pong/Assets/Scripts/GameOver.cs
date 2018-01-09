using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public UIManager uiManager;
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(uiManager.playerWon){
			text.text = "GAME OVER!\nPLAYER WON!";
		} else if(uiManager.enemyWon){
			text.text = "GAME OVER!\nENEMY WON!";
		}
	}
}
