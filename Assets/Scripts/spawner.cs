using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public GameObject apple;
    public float spawnPipeRate = 2f;
    public float spawnAppleRate = 6f;
    private float PipeTimer = 0f;
    private float AppleTimer = 0f;
    float PipeOffestY = 3f;
    float AppleOffestY = 5f;


    void Start()
    {
        SpawnPipe();
        SpawnApple();
    }

    void Update()
    {
        if (PipeTimer < spawnPipeRate)
        {
            PipeTimer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            PipeTimer = 0f;
        }
        if (AppleTimer < spawnAppleRate)
        {
            AppleTimer += Time.deltaTime;
        }
        else
        {
            SpawnApple();
            AppleTimer = 0f;
        }
    } 

    void SpawnPipe()
    {
        float highestPoint = transform.position.y + PipeOffestY;
        float lowestPoint = transform.position.y - PipeOffestY;
        float randomY = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, randomY, 0), transform.rotation);
    }
    void SpawnApple()
    {
        float highestPoint = transform.position.y + AppleOffestY;
        float lowestPoint = transform.position.y - AppleOffestY;
        float randomY = Random.Range(lowestPoint, highestPoint);
        float X = transform.position.x + 13;
        Instantiate(apple, new Vector3(X, randomY, 0), transform.rotation);
    }
}
