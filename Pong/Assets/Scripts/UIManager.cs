using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	GameObject[] pauseObjects, finishObjects;
	public BoundController rightBound;
	public BoundController leftBound;
	public bool isFinished;
	public bool playerWon, enemyWon;

	// Use this for initialization
	void Start () {
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");
		hideFinished();
	}
	
	// Update is called once per frame
	void Update () {

		if(rightBound.enemyScore >= 7 && !isFinished){
			isFinished = true;
			enemyWon = true;
			playerWon = false;
		} else if (leftBound.playerScore >= 7  && !isFinished){
			isFinished = true;
			enemyWon = false;
			playerWon = true;
		}

		if(isFinished){
			showFinished();
		}

		
		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.P) && !isFinished)
		{
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePaused();
			}
		}


		if(Time.timeScale == 0  && !isFinished){
			//searches through pauseObjects for PauseText
			foreach(GameObject g in pauseObjects){
				if(g.name == "PauseText")
					//makes PauseText to Active
					g.SetActive(true);
			}
		} else {
			//searches through pauseObjects for PauseText
			foreach(GameObject g in pauseObjects){
				if(g.name == "PauseText")
					//makes PauseText to Inactive
					g.SetActive(false);
			}
		}
	}
	
	
	//Reloads the Level
	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
	
	//controls the pausing of the scene
	public void pauseControl(){
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			hidePaused();
		}
	}
	
	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	//shows objects with ShowOnFinish tag
	public void showFinished(){
		foreach(GameObject g in finishObjects){
			g.SetActive(true);
		}
	}
	
	//hides objects with ShowOnFinish tag
	public void hideFinished(){
		foreach(GameObject g in finishObjects){
			g.SetActive(false);
		}
	}
	
	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
}
