using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 60f;
    private float countDown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime; //The countdown starts at maxTime
    }

    // Update is called once per frame
    void Update()
    {

        countDown -= Time.deltaTime; //To our countdown we less the rendering time in seconds of frames (deltaTime)
        Debug.Log(countDown);

        if (countDown <= 0)
        {

            Debug.Log("YOU HAVE RUN OUT OF TIME... You lose!!");
            Coin.coinsCount = 0;

            SceneManager.LoadScene("MainScene");
        }
    }
}
