using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padedmaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ladri;
    public GameObject pp;
    void Start()
    {
        // loop to add ladris
        for(int i = 0; i < 4; i++)
        for(int j = 0; j < 13; j++)
        {
        {
        Instantiate(ladri,new Vector3(-4.75f+0.55f*i,-4.6f+0.8f*j,0f),Quaternion.identity); 
        Instantiate(ladri,new Vector3(4.75f-0.55f*i,-4.6f+0.8f*j,0f),Quaternion.identity); 
        }
        } 
    
    // add pegajocidad (fixed locations for now)
    //left
    for (int i = 0; i<3;i++)
    {
    Instantiate(pp,new Vector3(-2.97f,-4+i*(4),0f),Quaternion.identity);
    }
    
    //right
    for (int i=0;i<3;i++)
    {
    Instantiate(pp,new Vector3(2.97f,-3.2f+i*4,0f),Quaternion.Euler(0f,0f,-180f));
    }
    
    }

    // Update is called once per frame
    void Update()
    {

    }
}
