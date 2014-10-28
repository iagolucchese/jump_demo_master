using UnityEngine;
using System.Collections;

public class PlayerDestroyed : MonoBehaviour {

	public GameObject deathExplosionPrefab;
	public GameObject gameOverScreen;

	void OnDestroy()
	{
		Instantiate(deathExplosionPrefab,transform.position,Quaternion.identity); //instantiates the explosion prefab
		gameOverScreen.SetActive(true);
	}
}
