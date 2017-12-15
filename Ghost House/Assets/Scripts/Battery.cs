using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

	public int power = 4;

	public GameObject FlashLight;

	GameObject Player;

	int checkBat;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag("Player");

		FlashLight = Player;

		checkBat = FlashLight.gameObject.GetComponentInChildren<Flashlight>().currentPower;
		print("CkBat ="+checkBat);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player" && checkBat == 0 ){
			FlashLight.gameObject.GetComponentInChildren<Flashlight>().currentPower = power;
			Destroy(gameObject);
		}
	}

}
