using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {

	private GUIText textField;

	// Use this for initialization
	void Start () {
		textField = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	public void ChangeScore (float score) {
		textField.text = string.Format("Score: {0:f1}",score);
	}
}
