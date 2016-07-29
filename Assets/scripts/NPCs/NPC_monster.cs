using UnityEngine;
using System.Collections;

public class NPC_monster : MonoBehaviour 
{
    private QuestUI gameUI;
    public bool monster_quest;
	
	void Start () 
    {
        gameUI = GameObject.Find("GameUI").GetComponent<QuestUI>();
        monster_quest = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "Player")
        {
            monster_quest = true;
        }
    }

}
