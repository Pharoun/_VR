using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRotation : MonoBehaviour
{

    public GameObject car;

    void Start()
    {
        
    }

    void Update()
    {
        car.transform.Rotate(0, 0.2f, 0);
    }
}
