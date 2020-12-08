using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitelManager : MonoBehaviour
{
   public void ChangeGameSceen()
    {
        SceneManager.LoadScene("Game");
    }
}
