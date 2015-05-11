using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GUIText completionText;
	public GUIText victoryText;
	private int completion;
	//Change this to change the number of cubes needed for victory.
	private int victory = 5;

	void Start () {
		completion = 0;
		updateCompletion (); 
	}

	public void incrementCompletion ()
	{
		completion++;
		updateCompletion ();
		if (completion == victory) {
			victoryText.text = "Congratulations!\nYou Win!";
		}
	}
	
	void updateCompletion ()
	{
		completionText.text = "Cubes found: " + completion + "/" + victory;
	}

}
