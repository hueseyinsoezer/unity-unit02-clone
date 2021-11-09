using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsE : MonoBehaviour
{
    private float topBound = 20.0f;
    private float lowerBound = -8.0f;
    void Start()
    {
    }

    void Update()
    {

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
