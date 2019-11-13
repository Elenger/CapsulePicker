using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject collectible;
    public Vector3 center;
    public Vector3 size;
    public int maxCollectible = 10;
    public void Start()
    {
        int i = 0;
        while (i < 5) 
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2,size.x/2),0,Random.Range(-size.z/2,size.z/2));
            Instantiate(collectible, pos, Quaternion.identity);
            i++;
        }

        SpawnController.Instance.spawnCount = 5;
        StartCoroutine(SpawnTimer());
    }
    
    public void SpawnCollectible()
    {
        
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2,size.x/2),0,Random.Range(-size.z/2,size.z/2));
        
        if (SpawnController.Instance.spawnCount < maxCollectible)
        {
            Instantiate(collectible, pos, Quaternion.identity);
            SpawnController.Instance.spawnCount++;
        }
    }
    
    public IEnumerator SpawnTimer()
    {
        for (;;)
        {
            SpawnCollectible();
            yield return new WaitForSeconds(1);
        }
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0,0,1,0.5f);
        Gizmos.DrawCube(center,size);
    }
}
