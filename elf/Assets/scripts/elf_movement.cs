using UnityEngine;
using System.Collections;

public class elf_movement : MonoBehaviour 
{
    public int jump_force = 100;
    public int jump_gauge;
	// Use this for initialization
	void Start () 
    {
        jump_gauge = 2;
        
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (jump_gauge !=0 && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump_force * Time.deltaTime);
            jump_gauge -= 1;
        }
        
	}

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.collider.tag == "floor")
        {
            print("floor");
            jump_gauge = 2;
        }
    }
    
}
