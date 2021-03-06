using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHard : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 15.0f;//Boundary of movements value
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from player
            Instantiate(projectilePrefab, transform.position+new Vector3(0,15/10, 15 / 10)
                , projectilePrefab.transform.rotation);
        }

    }

}
