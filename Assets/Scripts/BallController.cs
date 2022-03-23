using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public ParticleSystem particle;

    private void Awake() {
        particle = GetComponentInChildren<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision) {
        particle.Play();
    }
}
