using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerCar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider PlayerCar)
    {
        if (PlayerCar.transform.tag == "Player")
        {
            PlayerPrefs.SetInt("TotalCoins", PlayerPrefs.GetInt("TotalCoins", 0) + PlayerPrefs.GetInt("NumberOfCoins"));
            SceneManager.LoadScene(0);
        }
    }
}
