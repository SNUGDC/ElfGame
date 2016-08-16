using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {
    public bool is_noon;
    Vector2 up;
    Vector2 down;
	// Use this for initialization
	void Start () 
    {

        is_noon = true;
        up = new Vector2(0, 0);
        down = new Vector2(0, 15);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetButtonDown("Vertical")&&Input.GetAxis("Vertical")>0&&is_noon)
        {
            transform.position = up;
            is_noon = false;
        }
        if(Input.GetButtonDown("Vertical")&&Input.GetAxis("Vertical")<0&&!is_noon)
        {
            transform.position = down;
            is_noon = true;
        }
	}
}
