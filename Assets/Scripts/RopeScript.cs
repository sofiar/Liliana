using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    public GameObject hook;
    public GameObject player;
    float distance_to_hook;
    Vector3 LookDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookDirection = new Vector3(hook.transform.position.x-player.transform.position.x,hook.transform.position.y
        -player.transform.position.y, 0f);

        distance_to_hook = (hook.transform.position-player.transform.position).magnitude;
        transform.localScale = new Vector3(transform.localScale.x,distance_to_hook,1);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, LookDirection);

        
    }
}
