using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max; 
	int min; 
	int guess; 
	
	void Start () {
		StartGame();		
	}
	
	void StartGame (){
		max  = 1000; 
		min = 1; 
		guess = 500;		
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");		
		
		print ("The highest number that you can pick is " + max);
		print ("The lowest number that you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + " ?");
		print ("Use up arrow for higher, down arrow for lower, or return for equals");
		
		max += 1;  	
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			// print ("Up arrow was pressed.");
			min = guess; 
			NextGuess();			
		}	
		
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			//print ("Down arrow was pressed."); 
			max = guess; 
			NextGuess();
		}	
		
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print ("I won."); 
			StartGame();
		}	
	}
		
		void NextGuess () {
			guess = (max + min) / 2; 
			print ("Is it higher or lower than " + guess + " ?");
			print ("Use up arrow for higher, down arrow for lower, or return for equals"); 		
		}
	
}
