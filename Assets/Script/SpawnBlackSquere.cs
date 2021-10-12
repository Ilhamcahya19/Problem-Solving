using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlackSquere : MonoBehaviour
{
    public GameObject kotakHitam;
    
    private void Start() {
        BlackSquereSpawner();
    }
    
    public void BlackSquereSpawner()
    {
        bool BlackSquereSpawned = false;
        while (!BlackSquereSpawned)
        {
            Vector3 BlackSquerePosition = new Vector3(Random.Range(-7f,7f), Random.Range(-4f,4f), 0f);
            if((BlackSquerePosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                BlackSquereSpawned = true;
                StartCoroutine(DelaySpawn());
            }
        }
    }
    IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(2);
        Vector3 BlackSquerePosition = new Vector3(Random.Range(-5f,5f), Random.Range(-3f,3f), 0f);
        Instantiate(kotakHitam, BlackSquerePosition, Quaternion.identity);
    }
}
