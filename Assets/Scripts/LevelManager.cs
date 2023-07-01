using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /// <summary>
    /// LevelManager takes care of spawning/re-spawning the player
    /// and instantiating wall objects
    /// </summary>
public class LevelManager : MonoBehaviour
{
    public int lives_left;
    public GameObject player;
    public GameObject player_prefab;
    public Vector3 player_start_position;
    // Start is called before the first frame update
    void Start()
    {
        lives_left=Upgradeable.maxLives;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void kill(GameObject to_kill)
    {
        if (to_kill.CompareTag("Player"))
        {
            lives_left -= 1;
            Destroy(to_kill);
            if (lives_left<0)
            {
                gameOver();
            }
            else
            {
                reSpawn();
            }

        }

        else
        {
            Destroy(to_kill);
        }
    }

    public void gameOver()
    {
        //Open replay UI
        //destroy player
        print("Perdiste");
    }

    public void reSpawn()
    {
        player = Instantiate(player_prefab, player_start_position, Quaternion.identity);
        player.name = "Player";
    }
}
