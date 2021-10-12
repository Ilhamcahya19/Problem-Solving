using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 kecepatan;
    // Start is called before the first frame update
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    private void Start() 
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        kecepatan = rb.velocity;    
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        var speed = kecepatan.magnitude;
        var direction = Vector3.Reflect(kecepatan.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 12f);
    }
}
