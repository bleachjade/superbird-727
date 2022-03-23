using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSceneDestroyer : MonoBehaviour
{
    public float cap = 12f;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.transform.position.x - this.transform.position.x >= cap) {
            Destroy(this.gameObject);
        }
    }
}
