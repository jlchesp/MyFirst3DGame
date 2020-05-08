using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Coin.coinsCount++;
        Debug.Log("The game has started and now there are " + Coin.coinsCount + " coins");
    }

    // Update is called once per frame
    void Update() { }

    /*Method that is called automatically when another collider 
    contact the one assigned this script*/
    private void OnTriggerEnter(Collider otherCollider)
    {

        if (otherCollider.CompareTag("Player"))
        { //Conditional that collects the tag assigned to the player

            Coin.coinsCount--; //Reverse counter for when you collect coins

            if (Coin.coinsCount == 0)
            {

                Debug.Log("You win!!");
                GameObject gameManager = GameObject.Find("GameManager"); //We instantiate our gameManager to destroy it once all the coins have been collected
                Destroy(gameManager);

                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

                /*Loop that goes through our fireworksSystem array
                that contains all the gameObjects with the tag "FireWorks"*/

                foreach (GameObject fireworks in fireworksSystem)
                {
                    fireworks.GetComponent<ParticleSystem>().Play(); //Once finished, we start the fireworks
                }
            }

            Destroy(gameObject); //Destroy the gameObject assigned to this script
        }
    }

}
