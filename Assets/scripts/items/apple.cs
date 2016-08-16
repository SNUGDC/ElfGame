using UnityEngine;
using System.Collections;

public class apple : MonoBehaviour 
{
    public float pointPerOne = 5;

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
        if (col.gameObject.tag == "Player" && col.GetComponent<elf_inventory>().can_accept_apple)
        {
            PlayerPrefs.SetFloat("score", PlayerPrefs.GetFloat("score") + pointPerOne);
            col.GetComponent<elf_inventory>().apple += 1;
            Destroy(gameObject);
        }
    }
}
