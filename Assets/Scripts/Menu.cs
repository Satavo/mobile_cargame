using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject PlayerCar;
    public TextMeshProUGUI yourcoinstext;
    public static int totalcoins;
    public void Awake()
    {
        totalcoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }
    void Start()
    {
        yourcoinstext.text = totalcoins.ToString();
    }
    void Update()
    {
        
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeCar(string CarName)
    {
        Object.Destroy(PlayerCar);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
