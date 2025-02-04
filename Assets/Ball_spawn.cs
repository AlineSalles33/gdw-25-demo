using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_spawn : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        Instantiate(ball);
    }
}
