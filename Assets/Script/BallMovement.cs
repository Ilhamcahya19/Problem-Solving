using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D playerRigidbody;
    // Start is called before the first frame update

    private void Awake() 
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");//tombol a,d
        playerRigidbody.velocity = new Vector2(speed * horizontal, playerRigidbody.velocity.y);
        float vertical = Input.GetAxisRaw("Vertical");//tombol w,s
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, speed*vertical);
    }
}
