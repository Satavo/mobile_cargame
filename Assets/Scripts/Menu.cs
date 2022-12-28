using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Menu : MonoBehaviour
{
    public GameObject PlayerCar;
    public TextMeshProUGUI yourcoinstext;
    public TextMeshProUGUI highscoretext;
    public static int totalcoins = 0;
    public static int highscore = 0;
    public void Awake()
    {
        Highscore();
        totalcoins = PlayerPrefs.GetInt("TotalCoins");
        PlayerPrefs.SetInt("NumberOfCoins", 0);
        PlayerStats.numberofcoins = 0;

    }
    void Start()
    {
        highscoretext.text = "Your Highscore: " + highscore.ToString();
        yourcoinstext.text = totalcoins.ToString();
    }
    void Update()
    {
        
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("NumberOfCoins", 0);
        PlayerStats.numberofcoins = 0;
    }
    public void ChangeCar(string CarName)
    {
        Object.Destroy(PlayerCar);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    public void Highscore()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
        if (PlayerStats.numberofcoins > highscore)
        {
            PlayerPrefs.SetInt("HighScore", PlayerStats.numberofcoins);
        }
    }
}
