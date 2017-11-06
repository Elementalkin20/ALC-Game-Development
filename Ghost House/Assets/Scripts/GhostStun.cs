using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	//bool lightCheck;

	// Use this for initialization
	void Start () {
		//  lightCheck = GetComponent<Flashlight>().lightOn;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){


		if(other.gameObject.name == "Ghost"){
			print ("Ghost is Stunned");
		}
	}
}
