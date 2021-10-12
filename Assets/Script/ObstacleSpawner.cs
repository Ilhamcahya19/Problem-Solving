using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject kotak;
    public float xMin, xMax, yMin, yMax;
    // Start is called before the first frame update
    void Start()
    {
        
        Spawn();
    }

    void Spawn ()
    {
       int penghitungObjek = Random.Range(5, 10);
       for (int i = 0; i < penghitungObjek; i++)
       {
           float randomX = Random.Range(xMin, xMax);
           float randomY = Random.Range(yMin, yMax);
           Instantiate(kotak, new Vector2(randomX, randomY), Quaternion.identity);
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
