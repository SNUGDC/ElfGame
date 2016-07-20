using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameUI : MonoBehaviour {

    public Text print_score;
    private int total_score = 0;
	// Use this for initialization
	void Start () 
    {
        display_Score(0);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void display_Score(int score)
    {
        total_score += score;
        print_score.text = "score" + total_score.ToString();
    }
}
