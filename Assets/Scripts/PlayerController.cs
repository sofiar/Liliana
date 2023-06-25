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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        transform.position += direction*speed;

        MousePositionWorld = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));


        print(MousePositionWorld);
        LookDirection = new Vector3(MousePositionWorld.x-transform.position.x,MousePositionWorld.y
        -transform.position.y, 0f);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, LookDirection);

        // transform.rotation.SetLookRotation(Vector3.forward,new Vector3(MousePositionWorld.x-transform.position.x,MousePositionWorld.y
        // -transform.position.y,0f));

    }
}
