using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    Vector3 distance;
    void Start()
    {
        distance=transform.position-ball.transform.position;
    }

    
    void Update()
    {
        transform.position=new Vector3(transform.position.x,transform.position.y,ball.transform.position.z+distance.z);

    }
      void OnTriggerEnter(Collider other)
        {
            if(other.tag=="Triger")
            {
               GameManager._Instance.TrigerPlane();
            }
        }
}
