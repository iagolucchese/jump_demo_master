using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	public GameObject inGameHUD;
	public GameObject player;

	public Vector2 boxSize = new Vector2(500,450);  //default values that get 
	public Vector2 boxOffset = new Vector2(160,100);//changed in runtime, hopefully

	public Vector2 buttonSize = new Vector2(100,30);
	public Vector2 playButtonOffset = new Vector2(160,150);
	public Vector2 quitButtonOffset = new Vector2(160,270);

	public void StartGame() {
		Time.timeScale = 1; //lets the game run again
		player.SetActive(true); //releases the lock on the mouse controls
		inGameHUD.SetActive(true); //activates the in game HUD again

		gameObject.SetActive(false); //and finally, disables the whole Menu GUI
	}

	void OnGUI() {
		GUI.Box (new Rect(boxOffset.x,boxOffset.y,boxSize.x,boxSize.y),"");

		if(GUI.Button(new Rect(playButtonOffset.x,playButtonOffset.y,buttonSize.x,buttonSize.y), "Play Game")) {
			StartGame();
		}

		if(GUI.Button(new Rect(quitButtonOffset.x,quitButtonOffset.y,buttonSize.x,buttonSize.y), "Quit")) {
			Application.Quit();
		}
	}

	// Use this for initialization
	void Start () {
		Time.timeScale = 0; //pauses the whole game, although UI still works

		boxSize = new Vector2(Screen.width*0.7f,Screen.height*0.7f);
		boxOffset = new Vector2(Screen.width*0.15f,Screen.height*0.15f);

		buttonSize = new Vector2(Screen.width*0.3f,Screen.height*0.1f);
		playButtonOffset = new Vector2(boxOffset.x + boxSize.x*0.3f,boxOffset.y + boxSize.y*0.2f);
		quitButtonOffset = new Vector2(boxOffset.x + boxSize.x*0.3f,boxOffset.y + boxSize.y*0.7f);
	}
}
