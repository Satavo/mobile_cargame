using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateAnim : MonoBehaviour
{
    [Range(0,100)]
    public int rotationspeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationspeed * Time.deltaTime, 0);
    }
}
