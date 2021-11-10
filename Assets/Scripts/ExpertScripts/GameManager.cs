using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    public void AddScore(int val)
    {
        score += val;
        Debug.Log("Score: "+ score);

    }
    public void AddLives(int val)
    {
        lives += val;
        if (lives <= 0 )
        {
            Debug.Log("Lives: 0, "+"Game Over");
        }
        else
        {
            Debug.Log("Lives: "+ lives);
        }
    }

}
