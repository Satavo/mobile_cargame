using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PoliceLights : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public bool lightchange;
    public float lighttime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        // Simple script to flash the lights, probably a better way to do this
        lighttime += 1;
        if (lighttime > 10)
        {
            lighttime = 0;
            if (lightchange == false)
            {
                lightchange = true;
                blue.SetActive(true);
                red.SetActive(false);
            }
            else
            {
                lightchange = false;
                blue.SetActive(false);
                red.SetActive(true);
            }
        }
    }
}
