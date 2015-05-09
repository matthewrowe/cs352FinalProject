using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float smoothing = 5f;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

		float xrotation = Input.GetAxis ("Mouse X") * 3;
		float yrotation = Input.GetAxis ("Mouse Y") * 3;

		offset = Quaternion.Euler (yrotation, xrotation, 0) * offset;

		Vector3 targetCamPos = player.transform.position + offset;
		transform.position = Vector3.Slerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
		transform.LookAt(player.transform);
	}
}
