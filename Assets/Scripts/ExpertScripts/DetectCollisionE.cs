using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionE : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check if the other tah was the Player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        //Check if the other tag was an Animal, if so add points to the score
        else if (other.gameObject.CompareTag("Food"))
        {
            
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(other.gameObject);
        }

    }

}
