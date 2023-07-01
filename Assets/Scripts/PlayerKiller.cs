using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public GameObject LevelManager;
    // Start is called before the first frame update
    void Start()
    {
        if (!LevelManager)
        {
            LevelManager = GameObject.Find("LevelManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LevelManager.GetComponent<LevelManager>().kill(other.gameObject);
        }
    }
}
