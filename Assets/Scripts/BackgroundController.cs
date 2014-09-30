using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject BGPrefab;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Vector3 newPos = this.transform.position;
			newPos.y += 10;
			GameObject bg = Instantiate(BGPrefab,newPos,this.transform.rotation) as GameObject;
			bg.name = "[Background]";
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
