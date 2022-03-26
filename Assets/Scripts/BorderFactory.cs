using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFactory : MonoBehaviour
{
    public float cap = 40f;
    public float nextBorderX = 12f;
    public GameObject origin;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.transform.position.x + cap*3 > nextBorderX) {
            GameObject clone = Instantiate(origin);
            clone.transform.position = new Vector3(nextBorderX, 0, 0);
            nextBorderX += cap;
        }
    }
}
