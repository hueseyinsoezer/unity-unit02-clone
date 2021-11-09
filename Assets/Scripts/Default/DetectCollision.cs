using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GUIController gUIController;
    void Start()
    {
        gUIController = GameObject.Find("GUIController").GetComponent<GUIController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gUIController.AddLives(-1);Debug.Log("Bana Çarptý");
            Destroy(gameObject);
        }
        else
        {
            gUIController.AddScore(+1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }

}
