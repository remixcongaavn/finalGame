using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void DonePlay()
    {
        Debug.Log("Go to exit scene.......");
        SceneManager.LoadScene("3Exit");
    }
}
