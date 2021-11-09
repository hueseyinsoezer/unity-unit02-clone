using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionMed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("Temas: Game Over");
        }else if (other.gameObject == gameObject)
        {

        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }

}
