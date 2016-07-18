using UnityEngine;
using System.Collections;

public class quest_items : MonoBehaviour {
    public float speed = 5f;
    private GameUI gameUI;
	void Start () 
    {
        gameUI = GameObject.Find("GameUI").GetComponent<GameUI>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }
    }
}
