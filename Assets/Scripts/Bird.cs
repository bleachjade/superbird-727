using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower = 400f;
    public float speed = 1f;
    public bool isDead = false;
    public int score = 0;
    public AudioSource audioJump;
    public AudioSource audioScore;
    public AudioSource audioCollision;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            // Left click
            if (Input.GetMouseButtonDown(0)) {
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                audioJump.Play();
            }
        }
    }

    private void OnCollisionEnter(Collision collision) {
        isDead = true;
        audioCollision.Play();
    }

    private void OnTriggerEnter(Collider other) {
        score++;
        increaseSpeedOnHigherScore();
        audioScore.Play();
    }

    private void increaseSpeedOnHigherScore() {
        if ((score % 4) == 0) {
            speed = speed * 1.2f;
        }
    }
}
