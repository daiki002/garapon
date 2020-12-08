using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;

    public GameObject StartButton;
    public GameObject ResetButton;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "1":
                Text1.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
            case "2":
                Text2.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
            case "3":
                Text3.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
            case "4":
                Text4.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
            case "5":
                Text5.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
            case "6":
                Text6.SetActive(true);
                StartButton.SetActive(false);
                ResetButton.SetActive(true);
                break;
        }
    }
}
