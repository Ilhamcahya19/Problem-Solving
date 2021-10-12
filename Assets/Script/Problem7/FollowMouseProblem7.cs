using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseProblem7 : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            score.scoreadd();
            Destroy(col.gameObject);
        }
    }
}
