using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manu : MonoBehaviour
{
    public void OnPlayerButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void Leve1Button()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void Leve2Button()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
    public void OnQuit2Button()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void OnQuit1Button()
    {
        Application.Quit();
    }
}
