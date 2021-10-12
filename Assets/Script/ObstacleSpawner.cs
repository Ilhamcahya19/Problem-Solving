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
        StartCoroutine(SpawnSprite());
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

   //sprite muncul ketika 3 detik
    public IEnumerator SpawnSprite()
    {
        if (transform.childCount < 10)
        {
            float randomX = Random.Range(-6, 6);
            float randomY = Random.Range(-4, 4);

            Instantiate(kotak, new Vector2(randomX, randomY), Quaternion.identity); 
            
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnSprite()); 
    }
}
