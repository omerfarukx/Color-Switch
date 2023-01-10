using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform topPozisyon;


    void Update()
    {
        if (topPozisyon.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, topPozisyon.position.y, transform.position.z);
        }
    }
}
