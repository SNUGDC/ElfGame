using UnityEngine;
using System.Collections;

public class elf_inventory : MonoBehaviour 
{
    public int apple;
    public int weed;
    public int monster;
    public bool can_accept_apple;
    public bool can_accept_weed;
    public bool can_accept_monster;

	// Use this for initialization
	void Start () 
    {
        apple = 0;
        weed = 0;
        monster = 0;
        can_accept_apple = false;
        can_accept_monster = false;
        can_accept_weed = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

}
