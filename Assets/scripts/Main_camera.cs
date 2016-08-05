using UnityEngine;
using System.Collections;

public class Main_camera : MonoBehaviour 
{
    public GameObject player;

    private Vector3 offset;
    Vector3 correction = new Vector3(2, 3, 0);

    void Start()
    {
        offset = transform.position - player.transform.position + correction;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
