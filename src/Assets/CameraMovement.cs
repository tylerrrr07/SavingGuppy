using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
	    
    }
    void Awake()
    {
        //camera.orthographicSize = Screen.height / 2;
    }
	
    // Update is called once per frame
    void Update()
    {
        Vector3 player = GameObject.Find("Player").transform.position;
        transform.position = new Vector3(player.x, player.y, transform.position.z);
    }
}
