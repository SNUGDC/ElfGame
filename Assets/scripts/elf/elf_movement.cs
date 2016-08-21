using UnityEngine;
using System.Collections;

public class elf_movement : MonoBehaviour 
{
    public float speed = 5f;
    public float jump_force = 300f;
    public int jump_gauge;
    public bool up_floor;
    public Vector2 velo;
    public GameObject EndPoint;
    Vector2 jumping;
	// Use this for initialization

    GameObject floor = GameObject.Find("short_floor");
	void Start () 
    {
        jump_gauge = 2;
        jumping = new Vector2(0, jump_force * Time.deltaTime);
        
	}
	
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (jump_gauge != 0 && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = jumping;
            print("Jump");
            jump_gauge -= 1;
        }
        velo = GetComponent<Rigidbody2D>().velocity;


        if(transform.position.x >= EndPoint.transform.position.x)
        {
            Vector3 reposition = new Vector3(0, transform.position.y, -1);
            transform.position = reposition;
        }

    }
	void Update () 
    {
        Physics2D.IgnoreLayerCollision(8,12, (GetComponent<Rigidbody2D>().velocity.y > 0.0f));
	}

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.collider.tag == "floor")
        {
            jump_gauge = 2;
        }
    }

    
    
}
