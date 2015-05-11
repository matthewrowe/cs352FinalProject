using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GUIText completionText;
	private int completion;

	void Start () {
		completion = 0;
		updateCompletion (); 
	}

	public void incrementCompletion ()
	{
		completion++;
		updateCompletion ();
	}
	
	void updateCompletion ()
	{
		completionText.text = "Cubes found: " + completion + "/ 5";
	}

}
