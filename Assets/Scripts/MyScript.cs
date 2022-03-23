using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    private void OnMouseDown()
    {
        print("HIT!");
        Destroy(gameObject);
    }

}
