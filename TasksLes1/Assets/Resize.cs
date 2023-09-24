using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called before the first frame update
    private float deltaResazi;
    private float maxVal;
    private float minVal;
    private float curVal;
    void Start()
    {
        deltaResazi = 0.05f;
        maxVal = 10f;
        minVal = -10f;
        curVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(deltaResazi, deltaResazi, deltaResazi) * Time.deltaTime;
        curVal += deltaResazi;
        if(curVal > maxVal)
            deltaResazi = -deltaResazi;
        if (curVal < minVal)
            deltaResazi = -deltaResazi;
    }
}
