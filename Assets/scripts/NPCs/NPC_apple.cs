using UnityEngine;
using System.Collections;

public class NPC_apple : MonoBehaviour 
{
    private QuestUI gameUI;
    public bool apple_quest;
	
	void Start () 
    {
        apple_quest = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "Player")
        {
            apple_quest = true;
        }
    }
}
