using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour
{
    bool pull = false;
    public float pullstrength=1;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pull)
        {
            Vector3 direction = (transform.position-player.transform.position).normalized;
            player.GetComponent<Rigidbody2D>().AddForce(direction*pullstrength);
            print(direction*pullstrength);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("sticky"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity=Vector3.zero;
            gameObject.transform.SetParent(other.gameObject.transform);
            gameObject.GetComponent<Rigidbody2D>().constraints=RigidbodyConstraints2D.FreezeAll;
            gameObject.GetComponent<PolygonCollider2D>().enabled=false;
            pull=true;
        }
        
    }
}
