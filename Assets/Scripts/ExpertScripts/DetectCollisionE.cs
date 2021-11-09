using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionE : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }

}
