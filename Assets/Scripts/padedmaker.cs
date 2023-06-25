using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padedmaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ladri;
    void Start()
    {
        for(int i = 0; i < 4; i++)
            for(int j = 0; j < 13; j++)
        {
        {
        Instantiate(ladri,new Vector3(-4.75f+0.55f*i,-4.6f+0.8f*j,0f),Quaternion.identity); 
        Instantiate(ladri,new Vector3(4.75f-0.55f*i,-4.6f+0.8f*j,0f),Quaternion.identity); 
        }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
