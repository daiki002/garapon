using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Routation : MonoBehaviour
{
    [SerializeField] GameObject[] ItemPrefab = null;

    float Speed;
    int number;
    int Hitcount;
   public bool Stopflag;
    bool StartFlag;

    private void Start()
    {
        StartFlag = false;
        Speed = -4f;
    }
    void Update()
    {
        if (StartFlag)
        {
            if (!Stopflag)
            {
                transform.Rotate(new Vector3(0.0f, 0, Speed));

            }
        }
    }

    public void StopGame()
    {
        Debug.Log(Hitcount);
        Hitcount++;
        if (Hitcount >= 3)
        {
            Stopflag = true;
            CreateItem();
        }
    }

    void CreateItem()
    {
        number = UnityEngine.Random.Range(0, ItemPrefab.Length);
        Instantiate(ItemPrefab[number]);
    }

    public void GameStart()
    {
        StartFlag = true;
    }

   
}
