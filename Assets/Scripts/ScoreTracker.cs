using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {

	private GUIText textField;

	public float currentHealth = 0f;
	public float currentScore = 0f;

	// Use this for initialization
	void Start () {
		textField = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		textField.text = string.Format("Health: {1:f2} Score: {0:f2}",currentScore,currentHealth);
	}
}
