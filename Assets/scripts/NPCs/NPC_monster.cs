using UnityEngine;
using System.Collections;

public class NPC_monster : MonoBehaviour 
{
    private QuestUI gameUI;
    public int heal = 1;
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
        if (col.gameObject.tag == "Player" && GameObject.Find("background").GetComponent<background>().is_noon)

        {
            col.GetComponent<elf_inventory>().can_accept_monster = true;
        }
        if(col.gameObject.tag == "Player" && GameObject.Find("background").GetComponent<background>().is_noon==false)
        {
            col.GetComponent<elf_gauge>().currentHealth += (float)heal;
            Destroy(gameObject);
        }

    }

}
