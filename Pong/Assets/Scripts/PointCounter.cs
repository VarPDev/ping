using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointCounter : MonoBehaviour {

	public GameObject rightBound;
	public GameObject leftBound;
	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.text = rightBound.GetComponent<BoundController>().enemyScore + "\t" + 
			leftBound.GetComponent<BoundController>().playerScore;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = rightBound.GetComponent<BoundController>().enemyScore + "\t" + 
			leftBound.GetComponent<BoundController>().playerScore;
	}
}
