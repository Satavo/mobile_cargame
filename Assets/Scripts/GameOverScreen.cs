using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Awake()
    {

    }
}
