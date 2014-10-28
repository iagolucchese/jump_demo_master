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

		if (currentHealth < 0) {
			currentHealth = 0;
			scoreTracker.currentHealth = currentHealth;
			PlayerDied();
		}
	}

	void PlayerDied() {
		Destroy(gameObject); //and self-destructs the player, which calls a OnDestroy function on another script
	}

	void Start () {
		currentHealth = maxHealth;
	}
	
	void Update () {
		HealthChange(-healthLostPerSecond * Time.deltaTime); //bleed out some health every frame
		scoreTracker.currentHealth = currentHealth;

		score += gameObject.rigidbody2D.velocity.y/10 * Time.deltaTime; //add 1 point to the score for every 10 meters
		scoreTracker.currentScore = score;
	}
}
