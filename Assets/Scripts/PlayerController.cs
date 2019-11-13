using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private Rigidbody rigidB;
    public int speed = 10;
    
    void Start () {
        rigidB = GetComponent<Rigidbody>();
    }

    void FixedUpdate () {
        if (Input.GetKey(KeyCode.W)) {
            rigidB.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidB.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            rigidB.AddForce(Vector3.right *speed);
        }
        if (Input.GetKey(KeyCode.A)) {
            rigidB.AddForce(Vector3.left *speed);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Collectibles")
        {
            Destroy(other.gameObject,0);
            ScoreController.Instance.score++;
            SpawnController.Instance.spawnCount--;
        }
    }
}
