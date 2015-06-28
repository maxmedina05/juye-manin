using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

    private static int _score = 0;
    Text _scoreText;
    float timer = 0;
	// Use this for initialization
	void Awake () {
        // Set up the reference.
        _scoreText = GetComponent<Text>();
        _score = 0;
	}

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
     int minutes = Mathf.FloorToInt(timer / 60F);
     int seconds = Mathf.FloorToInt(timer - minutes * 60);
     string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

     _scoreText.text = "Score: " + niceTime;
	}

    public static void Score(string streetName) {
            _score++;
        //Debug.Log("Player score 1: " + _score);
        // Set the displayed text to be the word "Score" followed by the score value.

    }
}
