using UnityEngine;
using System.Collections;

public class elf_gauge : MonoBehaviour 
{
    public int health;
    public Hashtable quest;
    int damage;
    int healing;
	// Use this for initialization
	void Start () 
    {
        health = 2;
        quest = new Hashtable();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "NPC")
        {
            healing = col.gameObject.GetComponent<NPC>().heal;
            health += healing;
        }
        if (col.GetComponent<Collider2D>().tag == "quest_item")
        {

        }
        if (col.GetComponent<Collider2D>().tag == "enemy")
        {
            damage = col.gameObject.GetComponent<enemy>().power;
            health -= damage;
        }
    }
}
