using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private float speed = 5;
	
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		NetworkView nView = GetComponent<NetworkView> ();
		if (nView.isMine)
		{
			InputMovement();
		}

	}

	void InputMovement(){
		//movement relative to camera
		Vector3 forward = new Vector3(0,0,1);
		forward.y = 0;
		forward = forward.normalized;
		
		Vector3 right = new Vector3 (forward.z, 0, -forward.x);
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = (moveHorizontal * right + moveVertical*forward).normalized;
		
		
		
		
		rb.AddForce (movement * speed);
	}
}