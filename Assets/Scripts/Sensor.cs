using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            GameObject obj = GameObject.Find("Body");
            obj.GetComponent<Routation>().StopGame();
        }
    }

   

    
}
