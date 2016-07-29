using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestUI : MonoBehaviour 
{
    public Text quest;
    
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    public void display_quest(string name, int items)
    {
        quest.text = name+"<color=#ff0000>" + items.ToString() + "</color>";

    }
}
