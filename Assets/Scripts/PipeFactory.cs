using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeFactory : MonoBehaviour
{
    public float cap = 4f;
    public float nextPipeX = 12f;
    public GameObject origin;
    public GameObject bird;
    public GameObject bird2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((bird.transform.position.x + cap*3 > nextPipeX) || (bird2.transform.position.x + cap*3 > nextPipeX)){
            GameObject clone = Instantiate(origin);
            clone.transform.position = new Vector3(nextPipeX, Random.Range(1f, -3.5f), 0);
            nextPipeX += cap;
        }
    }
}
