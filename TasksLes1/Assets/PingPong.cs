using UnityEngine;
using System;

public class PingPong : MonoBehaviour
{
  
    public Vector3 finishPosit;
    public float speed = 0.5f;
    public float x;
    public float y;
    public float z;
    public int valrand;

    void Start()
    {
        x = Randomiz(-3.25f, 0.1f);
        y = Randomiz(-4.25f, 0.25f);
        z = Randomiz(0.25f, 3.75f);
        finishPosit = new Vector3(x, z, y);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, finishPosit, speed * Time.deltaTime);
        if (gameObject.transform.position == finishPosit)
        {
            x = Randomiz(-3.25f, 0.1f);
            y = Randomiz(-4.25f, 0.25f);
            z = Randomiz(0.25f, 3.75f);
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


