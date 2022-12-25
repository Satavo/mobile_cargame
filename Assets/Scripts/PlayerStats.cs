using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static int numberofcoins;
    public TextMeshProUGUI coinstext;

    // Start is called before the first frame update
    private void Awake()
    {
        numberofcoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }

    // Update is called once per frame
    void Update()
    {
        coinstext.text = numberofcoins.ToString();
    }
}
