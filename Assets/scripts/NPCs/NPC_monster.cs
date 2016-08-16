using UnityEngine;
using System.Collections;

public class NPC_monster : MonoBehaviour 
{
    private QuestUI gameUI;
	
	void Start () 
    {
        gameUI = GameObject.Find("GameUI").GetComponent<QuestUI>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "Player")
        {
            col.GetComponent<elf_inventory>().can_accept_monster = true;
        }
    }

}
