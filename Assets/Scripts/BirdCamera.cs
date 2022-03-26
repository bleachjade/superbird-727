using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCamera : MonoBehaviour
{
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        if ( target == null) {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
    }
}
