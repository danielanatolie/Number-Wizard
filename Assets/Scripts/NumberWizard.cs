using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame();
	}
	
	void startGame () {
		max = 1000;
		min = 1; 
		guess = 500;
		
		max++; // Max will not be rounded to 999
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than "+guess+" ?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("Up arrow pressed");
			min = guess; 
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			startGame();
		}
	}
	
	void nextGuess() {
		guess = (max + min)/2; // Has will now be set to half-way between maximum and minimum
		print("Higher or lower than " + guess);
		print ("Up arrow for higher, down for lower, return for equal");
	}
}
