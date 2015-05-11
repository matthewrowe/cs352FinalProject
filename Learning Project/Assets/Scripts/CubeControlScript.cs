using UnityEngine;
using System.Collections;

public class CubeControlScript : MonoBehaviour {

	private GameController gameController;

	void Start(){
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		gameController = gameControllerObject.GetComponent <GameController>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			gameController.incrementCompletion();
			Destroy (gameObject);
			//TurnColor ();
			//Teleport ();
		}
	}

	/*
	void TurnColor(){
		Color col = new Color(Random.value, Random.value, Random.value);
		GetComponent<Renderer>().material.color = col;
	}

	void Teleport(){
		Vector3 pos = transform.position;
		pos.z = transform.position.z + 5;
		pos.x = (float)(4 * (Random.value - 0.5));
		transform.position = pos;
	}
	*/

}
