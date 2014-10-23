using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject BGPrefab;

	public GameObject parkedCarPrefab;
	public float spawnParkedCarsMax = 5f;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Vector3 newPos = this.transform.position;
			newPos.y += 10;
			GameObject bg = Instantiate(BGPrefab,newPos,this.transform.rotation) as GameObject;
			bg.GetComponent<BackgroundController>().SpawnParkedCars();
			bg.name = "[Background]";
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Player") {
			Destroy(this.gameObject);
		}
	}

	public void SpawnParkedCars() {
		float spawnCars = Random.Range(0f,spawnParkedCarsMax);
		for (int i = 0; i <= spawnCars; i++)
		{
			Vector3 carPosition = transform.position;
			int sideOfStreet = Random.Range(0,2); 
			if (sideOfStreet == 0) {
				carPosition += new Vector3(-4,Random.Range(-4f,4f),-6);
			} else {
				carPosition += new Vector3(4,Random.Range(-4f,4f),-6);
			}
			
			Instantiate(parkedCarPrefab,carPosition,Quaternion.identity);
		}
	}
}
