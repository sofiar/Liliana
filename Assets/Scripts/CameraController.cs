using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Vector3 velocity = Vector3.zero;
    Vector3 player_position_adjusted;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            player_position_adjusted = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            if ((player_position_adjusted-transform.position).magnitude>5)
            {
                transform.position=Vector3.SmoothDamp(transform.position,player_position_adjusted, ref velocity, 0.5f);
            
            }
        }
        else
        {
            player=GameObject.Find("Player");
        }
        
    }
}
