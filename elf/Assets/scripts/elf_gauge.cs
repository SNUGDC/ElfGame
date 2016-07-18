using UnityEngine;
using System.Collections;

public class elf_gauge : MonoBehaviour 
{
    public int health;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "NPC")
        {
            
        }
        if (col.GetComponent<Collider2D>().tag == "quest_item")
        {

        }
        if (col.GetComponent<Collider2D>().tag == "enemy")
        {
            health -= 1;
        }
    }
}
