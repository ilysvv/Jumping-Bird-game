using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0f;
    float offestY = 3f;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    } 

    void SpawnPipe()
    {
        float highestPoint = transform.position.y + offestY;
        float lowestPoint = transform.position.y - offestY;
        float randomY = Random.Range(highestPoint, lowestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, randomY, 0), transform.rotation);
    }
}
