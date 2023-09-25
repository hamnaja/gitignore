using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manu : MonoBehaviour
{
    public void OnPlayerButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Leve1Button()
    {
        SceneManager.LoadScene(2);
    }
    public void Leve2Button()
    {
        SceneManager.LoadScene(3);
    }
    public void OnQuit2Button()
    {
        SceneManager.LoadScene(0);
    }
    public void OnQuit1Button()
    {
        Application.Quit();
    }
}
