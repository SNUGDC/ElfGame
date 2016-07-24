using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {
    public float speed = 5f;
    public string mode;
    public bool is_noon;
	// Use this for initialization
	void Start () 
    {
        mode = "noon";
        is_noon = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetButtonDown("Vertical")&&Input.GetAxis("Vertical")>0&&is_noon)
        {
            transform.position = new Vector2(0,0);
            is_noon = false;
        }
        if(Input.GetButtonDown("Vertical")&&Input.GetAxis("Vertical")<0&&!is_noon)
        {
            transform.position = new Vector2(0, 15);
            is_noon = true;
        }
	}
}
