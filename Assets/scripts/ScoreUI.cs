using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUI : MonoBehaviour {

    public Text print_score;
    private int total_score = 0;
	// Use this for initialization
	void Start () 
    {
        total_score = PlayerPrefs.GetInt("Tot_SCORE", 0);
        display_Score(0);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void display_Score(int score)
    {
        total_score += score;
        print_score.text = "score <color=#ff0000>" + total_score.ToString()+"</color>";

        PlayerPrefs.SetInt("Tot_SCORE", total_score);
    }
}
