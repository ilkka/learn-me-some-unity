using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	int max;
	int min;
	int guess;

	static int Average (int max, int min)
	{
		return (max + min) / 2;
	}

	// Use this for initialization
	void Start ()
	{
		StartGame ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}

	void StartGame ()
	{
		max = 1001;
		min = 1;

		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + (max - 1) + ".");
		print ("The lowest number you can pick is " + min + ".");
		
		NextGuess ();
	}

	void NextGuess ()
	{
		guess = Average (max, min);
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal.");
	}
}
