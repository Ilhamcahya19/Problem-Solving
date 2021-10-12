using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float xForce;
    public float yForce;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void PushBall()
    {
        float arahRandom = Random.Range(0, 2);
        if (arahRandom < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(-xForce, yForce).normalized * speed);
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(xForce, yForce).normalized * speed);
        }
    }
    // Update is called once per frame
    void Update()
    {
        PushBall();
    }
}
