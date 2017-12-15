using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {
	
	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool BatSpawned;


	// Use this for initialization
	void Start () {
		BatSpawned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(BatSpawned == false){
			StartCoroutine(SpawnBat(spawnTime, battery));
		}
		else{
			SropCoroutine(SpawnBat(spawnTime, battery));
		}

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Battery"){
			BatSpawned = true;
		}
		else{
			BatSpawned = false;
		}
	}

	IEnumerator SpawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		instantiate(bat, spawnPoint.position, spawnPoint.rotation);
		BatSpawned = true;

	}


}
