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
        PlayerPrefs.SetInt("NumberOfCoins", 0);
        PlayerStats.numberofcoins = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("NumberOfCoins", 0);
        PlayerStats.numberofcoins = 0;
    }
    public void Awake()
    {

    }
}
