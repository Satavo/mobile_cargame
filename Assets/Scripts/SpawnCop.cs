using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnCop : MonoBehaviour
{
    public GameObject PoliceCar;
    public GameObject SpawnToObject;
    [SerializeField]
    private float TimeToSpawn;
    private float CurrentTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTimeToSpawn = TimeToSpawn;
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        Instantiate(PoliceCar, SpawnToObject.transform.position, SpawnToObject.transform.rotation);
        CurrentTimeToSpawn = TimeToSpawn;
    }
    void Update()
    {
        if (CurrentTimeToSpawn > 0)
        {
            CurrentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
        }
    }
}
