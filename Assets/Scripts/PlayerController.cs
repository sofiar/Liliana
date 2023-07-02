using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 direction;
    public Camera cam;
    Vector3 MousePositionWorld;
    Vector3 LookDirection;
    public GameObject hook;
    public GameObject rope;
    float when_stuck;

    GameObject hook_instance;
    GameObject rope_instance;
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePositionWorld = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));

        LookDirection = new Vector3(MousePositionWorld.x-transform.position.x,MousePositionWorld.y
        -transform.position.y, 0f);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, LookDirection);

        if (Input.GetMouseButtonDown(0))
        {
            when_stuck = Time.time;
            hook_instance = Instantiate(hook, transform.position+LookDirection.normalized*1.5f, Quaternion.identity);
            hook_instance.GetComponent<Rigidbody2D>().velocity=LookDirection.normalized*Upgradeable.hook_speed;
            hook_instance.GetComponent<HookScript>().player=gameObject;

            rope_instance = Instantiate(rope, transform.position,Quaternion.identity);
            rope_instance.GetComponent<RopeScript>().player=gameObject;
            rope_instance.GetComponent<RopeScript>().hook=hook_instance;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(hook_instance);
            Destroy(rope_instance);
        }

        if (Time.time - when_stuck > Upgradeable.stickLimit && hook_instance)
        {
            Destroy(hook_instance);
            Destroy(rope_instance);
        }



    }
}
