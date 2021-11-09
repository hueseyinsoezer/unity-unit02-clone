using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsMed : MonoBehaviour
{ 
    private float topBoundZ = 20.0f;
    private float lowerBoundZ = -8.0f;
    private float sideBound = 25.0f;

    void Update()
     {

         if (transform.position.z > topBoundZ)
         {
             Destroy(gameObject);
         }
         else if (transform.position.z < lowerBoundZ)
         {
             Destroy(gameObject);
             Debug.Log("Game Over!");
         }
         else if (transform.position.x > sideBound)
         {
             Destroy(gameObject);
             Debug.Log("Game Over!");
         }
         else if (transform.position.x < -sideBound)
         {
             Destroy(gameObject);
             Debug.Log("Game Over!");
         }
       





} 

}
