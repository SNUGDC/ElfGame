using UnityEngine;
using System.Collections;

public class quest_items : MonoBehaviour {
    private GameUI gameUI;
	void Start () 
    {
        gameUI = GameObject.Find("GameUI").GetComponent<GameUI>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }
    }
}
