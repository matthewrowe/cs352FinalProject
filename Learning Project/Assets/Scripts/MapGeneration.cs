using UnityEngine;
using System.Collections;

public class MapGeneration : MonoBehaviour {

	public Transform xpassage;
	public Transform ypassage;
	public Transform zpassage;
	// Use this for initialization
	void Start () {
		//x directional passages

		for (int x = 0; x < 4; x++) {
			for (int y = 0; y < 5; y++) {
				for (int z =0 ; z < 5; z++) {
					Instantiate(xpassage, new Vector3(18*x+9,18*y,18*z), Quaternion.identity);
				}
			}
		}

		//y directional passages
		for (int x = 0; x < 5; x++) {
			for (int y = 0; y < 4; y++) {
				for (int z =0 ; z < 5; z++) {
					Instantiate(ypassage, new Vector3(18*x,18*y+9,18*z), Quaternion.identity);
				}
			}
		}

		//z directional passages
		for (int x = 0; x < 5; x++) {
			for (int y = 0; y < 5; y++) {
				for (int z =0 ; z < 4; z++) {
					Instantiate(zpassage, new Vector3(18*x,18*y,18*z+9), Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
