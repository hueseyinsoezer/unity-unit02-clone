using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20.0f;
    private float lowerBound = -8.0f;
    private GUIController gUIController;
    void Start()
    {
        gUIController = GameObject.Find("GUIController").GetComponent<GUIController>();
    }

    void Update()
    {

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            gUIController.AddLives(-1);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            gUIController.AddLives(-1);
        }

    }
}
