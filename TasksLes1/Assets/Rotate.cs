using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime, 0, 20.0f* Time.deltaTime);
    }
}
