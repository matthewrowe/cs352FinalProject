using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed = 5;

	private Rigidbody rb;

	public Transform cameram;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{

		//movement relative to camera
		Vector3 forward = cameram.TransformDirection (Vector3.forward);
		forward.y = 0;
		forward = forward.normalized;

		Vector3 right = new Vector3 (forward.z, 0, -forward.x);

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = (moveHorizontal * right + moveVertical*forward).normalized;




		rb.AddForce (movement * speed);





		if (Input.GetKey ("space")){
			movement = new Vector3 (0, 5, 0);
			rb.AddForce(movement*speed);
		}

		if (Input.GetKeyDown ("u")) {
			Physics.gravity = new Vector3(0f,9.81f,0f);
		}
		if (Input.GetKeyDown ("o")) {
			Physics.gravity = new Vector3(0f,-9.81f,0f);
		}
		if (Input.GetKeyDown ("j")) {
			Physics.gravity = new Vector3(-9.81f,0f,0f);
		}
		if (Input.GetKeyDown ("l")) {
			Physics.gravity = new Vector3(9.81f,0f,0f);
		}
		if (Input.GetKeyDown ("i")) {
			Physics.gravity = new Vector3(0f,0f,9.81f);
		}
		if (Input.GetKeyDown ("k")) {
			Physics.gravity = new Vector3(0f,0f,-9.81f);
		}


	}

}
