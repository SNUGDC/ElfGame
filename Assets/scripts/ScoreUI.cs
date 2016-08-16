using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUI : MonoBehaviour {

    public Text scoreText;
    public float pointPerSec = 5f;

    private float totalScore; 

	void Start () 
    {
        PlayerPrefs.SetFloat("score", 0);
        totalScore = PlayerPrefs.GetFloat("score");

        display_Score(totalScore);
	}
	

	void Update ()
    {
        PlayerPrefs.SetFloat("score", totalScore);
        display_Score(PlayerPrefs.GetFloat("score"));
	}

    public void display_Score(float score)
    {
        totalScore = PlayerPrefs.GetFloat("score");
        totalScore += Time.deltaTime * pointPerSec;
        PlayerPrefs.SetFloat("score", totalScore);
        scoreText.text = "score <color=#ff0000>" + ((int)totalScore).ToString()+"</color>";
    }
}