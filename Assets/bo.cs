using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class bo : MonoBehaviour
{
    public void ChangeSceen()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangeTitel()
    {
        SceneManager.LoadScene("Titel");
    }
}
