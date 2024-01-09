using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetSpawn : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float timeDestroy = 5f;
    private float maxHeightRange = 1.5f;
    private float minHeightRange = 0.9f;
    [SerializeField] private GameObject pipes; 



    private float timer;

    void Start()
    {
       Spawner(); 
    }

    void Update()
    {
        if(timer > maxTime)
        {
            Spawner();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void Spawner()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(minHeightRange, maxHeightRange));
        GameObject let = Instantiate(pipes, spawnPosition, Quaternion.identity);

        Destroy(let, timeDestroy);
    }
}
