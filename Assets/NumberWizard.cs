using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization

    int max, min, guess;
    int maxGuessesAllowed = 10;

    public Text text;

    void Start () {
        StartGame();
	}

    void StartGame() {
        max = 1000;
        min = 1;
        // guess = 500;       
        NextGuess();

        // max += 1;
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        // guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();

        maxGuessesAllowed -= 1;

        if (maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
