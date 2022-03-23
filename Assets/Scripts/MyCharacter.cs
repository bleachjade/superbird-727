using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody rb;
    public float jumpPower = 5f;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        if (rb == null) {
            Debug.LogError("Rigidbody not found!");
        }
    }

    void Update()
    {
        float x_distance = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z_distance = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(new Vector3(x_distance, 0, z_distance));

        if (Input.GetButtonDown("Fire1")) {
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
}
