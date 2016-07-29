using UnityEngine;
using System.Collections;

public class NPC_weed : MonoBehaviour 
{
    private QuestUI gameUI;
    public bool weed_quest;
	
	void Start () 
    {
        weed_quest = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().tag == "Player")
        {
            weed_quest = true;
        }
    }

}
