﻿using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour 
{
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
        if (col.gameObject.tag == "Player" && col.GetComponent<elf_inventory>().can_accept_monster)
        {

            Destroy(gameObject);
            col.GetComponent<elf_inventory>().monster += 1;
        }
    }
}
