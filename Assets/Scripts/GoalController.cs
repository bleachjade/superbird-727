using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public int point = 0;

    private void OnCollisionEnter(Collision collision) {
        print(gameObject.name + ": " + collision.gameObject.name);
        
        if (collision.gameObject.name == "Ball") {
            point++;
        }
    }

    private void OnTriggerEnter(Collider other) {
        print("TriggerEnter: " + other.gameObject.name);
        if (other.gameObject.tag == "Ball") {
            point++;
            Destroy(other.gameObject, 3f);
        }
    }
}
