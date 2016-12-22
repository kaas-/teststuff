using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
    int maxGuesses = 10;

    public Text text;
	
	void Start () {
		StartGame();
	}

    void Update()
    {
        text.text = "My guess is " + guess;
    }
	
	void StartGame () {
		max = 1001;
		min = 1;
		guess = Random.Range(min, max);
		
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

	void NextGuess () {
        guess = Random.Range(min, max);
        maxGuesses--;
        if (maxGuesses <= 0)
            SceneManager.LoadScene("win");
	}
}
