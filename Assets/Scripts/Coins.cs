using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider PlayerCar)
    {
        if (PlayerCar.transform.tag == "Player")
        {
            PlayerStats.numberofcoins++;
            PlayerPrefs.SetInt("NumberOfCoins", PlayerStats.numberofcoins);
            Destroy(gameObject);
        }
    }
}
