using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;
	int rounds;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKeyDown("up"))
		{
			min = guess;
			Guess();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			Guess();

		}
		if (Input.GetKeyDown("return"))
		{
			print("I won in "+ rounds + " rounds!");
			print("--------------------------------");
			StartGame();
		}

		
	}

	void Guess(){
		guess = (max + min)/2;
		rounds++;
		print("Is the number lower or higher then " + guess + "?");
	}
	void StartGame()
	{
		min  = 1;
		max = 1000;
		guess = 500;
		rounds = 0;
		
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me.");

		print("The highest number um can pick is " + max);
		print("and the lowest is " + min);
		print("Press UP arrow for higher, DOWN for lower e RETURN for equal");
		print("Is the number lower or higher then " + guess + "?");
		max += 1;
	}
}
