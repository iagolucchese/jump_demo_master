using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	public GameObject inGameHUD;
	public GUIText scoreText;
	//public GameObject player;

	public Vector2 boxSize = new Vector2(500,450);  //default values that get 
	public Vector2 boxOffset = new Vector2(160,100);//changed in runtime, hopefully

	public Vector2 buttonSize = new Vector2(100,30);
	public Vector2 restartButtonOffset = new Vector2(160,150);
	public Vector2 quitButtonOffset = new Vector2(160,270);

	private bool showScreen = false;

	void OnGUI() {
		if (showScreen) {
			GUI.Box (new Rect(boxOffset.x,boxOffset.y,boxSize.x,boxSize.y),"");

			if(GUI.Button(new Rect(restartButtonOffset.x,restartButtonOffset.y,buttonSize.x,buttonSize.y), "Restart Game")) {
				Application.LoadLevel("Fire Car Game");
			}

			if(GUI.Button(new Rect(quitButtonOffset.x,quitButtonOffset.y,buttonSize.x,buttonSize.y), "Leave Game")) {
				Application.Quit();
			}
		}
	}

	void OnEnable() {
		Time.timeScale = 0; //pauses the whole game, although UI still works
		scoreText.text = string.Format("Score: {0:f1}",inGameHUD.GetComponentInChildren<ScoreTracker>().currentScore);
		inGameHUD.SetActive(false);
		
		boxSize = new Vector2(Screen.width*0.7f,Screen.height*0.7f);
		boxOffset = new Vector2(Screen.width*0.15f,Screen.height*0.15f);
		
		buttonSize = new Vector2(Screen.width*0.3f,Screen.height*0.1f);
		restartButtonOffset = new Vector2(boxOffset.x + boxSize.x*0.3f,boxOffset.y + boxSize.y*0.5f);
		quitButtonOffset = new Vector2(boxOffset.x + boxSize.x*0.3f,boxOffset.y + boxSize.y*0.7f);
		
		showScreen = true;
	}
}
