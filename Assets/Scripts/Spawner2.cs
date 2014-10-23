using UnityEngine;
using System.Collections;

// Spawns a given prefab occasionally at a random x position
public class Spawner2 : MonoBehaviour {

	public GameObject[] obstaclePrefabs;
	public float minObstacleDelay = 1f;
	public float maxObstacleDelay = 2f;

	public GameObject platformPrefab;
	public float minPlatformDelay = 1.5f;
	public float maxPlatformDelay = 2.5f;

	private float timeElapsed = 0f;
	private float currentObstacleDelay = 0f;
	private float currentPlatformDelay = 0f;

	void Start() {
		if (obstaclePrefabs == null || platformPrefab == null) {
			Debug.LogError("Missing a spawn type in either or both spawners");
			Destroy(this);
		} else {
			//time = platformDelay;
		}
		currentObstacleDelay = Random.Range(minObstacleDelay,maxObstacleDelay);
		currentPlatformDelay = Random.Range(minPlatformDelay,maxPlatformDelay);
	}

	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= currentObstacleDelay) {
			currentObstacleDelay += Random.Range(minObstacleDelay,maxObstacleDelay); //not the best solution

			float posX = Random.Range(-transform.localScale.x/5,transform.localScale.x/5);
			GameObject obstacle = Instantiate(obstaclePrefabs[Random.Range(0,obstaclePrefabs.Length)]) as GameObject;
			obstacle.transform.position = new Vector3(posX, transform.position.y, transform.position.z+4);
		}

		if (timeElapsed >= currentPlatformDelay) {
			currentPlatformDelay += Random.Range(minPlatformDelay,maxPlatformDelay); //not the best solution

			float posX = Random.Range(-transform.localScale.x/4,transform.localScale.x/4);
			GameObject platform = Instantiate(platformPrefab) as GameObject;
			platform.transform.position = new Vector3(posX, transform.position.y, transform.position.z+4);
		}
	}
}
