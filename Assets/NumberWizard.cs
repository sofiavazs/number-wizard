using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
  int max = 1000;
  int min = 1;
  int guess = 500;

    // Start is called before the first frame update
  void Start () {
    Debug.Log("Welcome to Number Wizard");
    Debug.Log("Pick a Number!Don't tell me what it is...");
    Debug.Log("The highest Number is:" + max);
    Debug.Log("The lowest Number is:" + min);
    Debug.Log("Tell me if your number is higher or lower than 500");
    Debug.Log("Push up = Higher, Push Down = lower, Push Enter = Correct");

    }

    // Update is called once per frame and updates the Start function
    void Update () {
       //Detects when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
          Debug.Log("Up Arrow key was pressed.");
          min = guess;
          Debug.Log(guess);
        }
         //Detects when the down arrow key is pressed down
        else if  (Input.GetKeyDown(KeyCode.DownArrow))
        {
          Debug.Log("Down Arrow key was pressed.");
          max = guess;
          Debug.Log(guess);

        }
        //Detects when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }
            
    }
}
