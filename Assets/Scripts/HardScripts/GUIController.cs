using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    private int lifePoint = 3, score = 0;

    public void AddLives(int val)
    {
        lifePoint += val;
        if (lifePoint <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Lives = " + lifePoint);
        }
        
    }
    public void AddScore(int val)
    {
        score += val;
        Debug.Log("Score = "+ score);
    }
}
