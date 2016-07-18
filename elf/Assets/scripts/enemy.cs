using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public float speed = 5f;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
