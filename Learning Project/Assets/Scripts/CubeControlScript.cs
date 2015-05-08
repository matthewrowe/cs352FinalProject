using UnityEngine;
using System.Collections;

public class CubeControlScript : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			TurnColor ();
			Teleport ();
		}
	}

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


}
