using UnityEngine;
using System.Collections;

public class elf_movement : MonoBehaviour 
{
    public float speed = 5f;
    public float jump_force = 300f;
    public int jump_gauge;
    Vector2 jumping;
	// Use this for initialization
	void Start () 
    {
        jump_gauge = 2;
        jumping = new Vector2(0, jump_force * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
	    if (jump_gauge !=0 && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = jumping;
            print("Jump");
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
