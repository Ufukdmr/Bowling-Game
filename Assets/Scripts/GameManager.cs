using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager _Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private int  trigerCount=0;

    [SerializeField]
    GameObject[] planes;
    [SerializeField]
    GameObject pin;

    public int Skor=0;

    [SerializeField]
    Text txt_Skor;

    public bool gameOver=false;
    void Start()
    {
        for (int i = 0; i < planes.Length; i++)
        {
            CreatePin(i);
        }
    }
   public void TrigerPlane()
    {
        planes[trigerCount].transform.position=new Vector3(0,0,planes[trigerCount].transform.position.z+(17.72f*planes.Length));
        CreatePin(trigerCount);
        trigerCount++;
        if(trigerCount==planes.Length)
        {
            trigerCount=0;
        }
    }
    private void CreatePin(int a)
    {
       int pinCount= UnityEngine.Random.Range(4,8);
       for (int i = 0; i < pinCount; i++)
       {
           Vector3 position=new Vector3(UnityEngine.Random.Range(-2.34f,2.34f),0.72f,UnityEngine.Random.Range(planes[a].transform.position.z-(17.72f/2),planes[a].transform.position.z+(17.72f/2)));
           Instantiate(pin, position, Quaternion.Euler(-90, 0, 0));
       }
    }

    public void GameOver()
    {
        gameOver=true;
        Debug.Log("GameOver!!!");
    }

    void Update()
    {
        txt_Skor.text=Skor.ToString();
    }
}
