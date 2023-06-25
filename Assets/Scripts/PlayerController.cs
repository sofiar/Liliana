using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 direction;
    public float speed;
    public Camera cam;
    Vector3 MousePositionWorld;
    Vector3 LookDirection;
    public float hook_speed;
    public GameObject hook;
    public GameObject rope;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        transform.position += direction*speed;

        MousePositionWorld = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));

        LookDirection = new Vector3(MousePositionWorld.x-transform.position.x,MousePositionWorld.y
        -transform.position.y, 0f);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, LookDirection);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject hook_instance;
            hook_instance = Instantiate(hook, transform.position+LookDirection.normalized*1.5f, Quaternion.identity);
            hook_instance.GetComponent<Rigidbody2D>().velocity=LookDirection*hook_speed;

            GameObject rope_instance;
            rope_instance = Instantiate(rope, transform.position,Quaternion.identity);
            rope_instance.GetComponent<RopeScript>().player=gameObject;
            rope_instance.GetComponent<RopeScript>().hook=hook_instance;

            
        }

        // create a line between the hook and the player.
        // option 1: a square sprite with the y scale set to the right distance and rotation.
        // option 2: a number of dots with their distance varying (harder)


    }
}
