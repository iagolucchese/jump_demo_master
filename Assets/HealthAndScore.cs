using UnityEngine;
using System.Collections;

public class HealthAndScore : MonoBehaviour {

	public ScoreTracker scoreTracker;

	public float maxHealth = 100f;
	public float currentHealth;
	public float healthLostPerSecond = 2f;
	public float powerupHealthBonus = 10f;
	public float obstacleHealthLoss = 10f;

	public float score = 0f;
	public float scoreBonusForObstacle = 5f;
	public float scoreBonusForPowerup = 10f;

	public void HitObstacle() {
		HealthChange(-obstacleHealthLoss);
		score += scoreBonusForObstacle;
	}

	public void HitPowerup() {
		HealthChange(powerupHealthBonus);
		score += scoreBonusForPowerup;
	}

	void HealthChange(float health) { //pass negative value to decrease health
		currentHealth += health;

		if (currentHealth > maxHealth)
			currentHealth = maxHealth;

		if (currentHealth < 0)
			PlayerDied();
	}

	void PlayerDied() {
		//TODO: end game here
	}

	void Start () {
		currentHealth = maxHealth;
	}
	
	void Update () {
		HealthChange((healthLostPerSecond/1000) * Time.deltaTime); //bleed out some health every frame		
	}
}
