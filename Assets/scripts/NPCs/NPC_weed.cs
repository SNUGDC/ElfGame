using UnityEngine;
using System.Collections;

public class NPC_weed : MonoBehaviour 
{
    private QuestUI gameUI;
    public int heal = 1;
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && GameObject.Find("background").GetComponent<background>().is_noon)
        {
            col.GetComponent<elf_inventory>().can_accept_weed = true;
        }
        if (col.gameObject.tag == "Player" && GameObject.Find("background").GetComponent<background>().is_noon==false)
        {
            col.GetComponent<elf_gauge>().currentHealth += (float)heal;
            Destroy(gameObject);
        }
    }

}
