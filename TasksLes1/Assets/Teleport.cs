using System;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 finishPosit;
    public float x;
    public float y;
    public float z;
    public int valrand;
    public float timePause;
    float timeP = 0.0f;
    

    void Start()
    {
        x = Randomiz(-4f, 4f);
        y = Randomiz(-5f, 5f);
        z = Randomiz(-5f, 5f);
        finishPosit = new Vector3(x, z, y);
        timePause = 5f;
    }


    // Update is called once per frame
    void Update()
    {
        
        
        if (Time.time > timeP)
        {
            timeP = Time.time + timePause;
            transform.position = finishPosit;
            x = Randomiz(-4f, 4f);
            y = Randomiz(-5f, 5f);
            z = Randomiz(-5f, 5f);
            finishPosit = new Vector3(x, z, y);
        }
    }

    private float Randomiz(float min, float max)
    {
        System.Random randm = new System.Random();
        valrand = randm.Next(1, (Convert.ToInt32(max - min)) * 100);
        return Convert.ToSingle(valrand / 100) + min;
    }
}
