using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Pin : MonoBehaviour
{
    float timer=0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag=="Ball")
        {
            timer=timer+Time.deltaTime;
           
            if(timer==3)
            {
                this.GetComponent<MeshCollider>().isTrigger=true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="GameArea")
        {
            GameManager._Instance.Skor++;  
        }
    }
}
