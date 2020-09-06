using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard ..yoo");
        Debug.Log("Pick a number dont tell me what it is ...");
        Debug.Log("The highest number you can pick: " + max);
        Debug.Log("The lowest number you can pick: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher , Push Down = Lower , Push Enter = Correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();



        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("im a genius.");
        }

    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("is it higher or lower than " + guess);
    }
}
