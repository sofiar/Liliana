using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 direction;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        transform.position += direction*speed;
    }
}
