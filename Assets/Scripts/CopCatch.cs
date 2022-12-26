using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopCatch : MonoBehaviour
{
    [SerializeField]
    public int CatchHits;
    public int CurrentCatchHits;
    public GameObject PlayerCar;
    public GameOverScreen GameOverScreen;
    public PrometeoEditor carController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            CurrentCatchHits++;
        }
        if (CurrentCatchHits == CatchHits)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        
        GameOverScreen.Setup();
    }
}
