using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlayButtonManager : MonoBehaviour
{

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void UnloadGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
