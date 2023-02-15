using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Maximum time to complete level (in seconds)
    public float MaxTime = 60f;
    // Countdown
    [SerializeField] // just used to view the inspecter
    private float CountDown = 0;

    // Use this for initialization
    void Start ()
    {
        CountDown = MaxTime;
    }

    // Update is called once per frame
    void Update ()
    {
        // Reduce time
        CountDown -= Time.deltaTime;
        // Restart level if time runs out
        if(CountDown <= 0)
        {
            // Reset coin count
            Coin.CoinCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
