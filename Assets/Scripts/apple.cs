using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    public float speed;
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
            Destroy(gameObject);
        }
        if (transform.position.x < -27f)
        {
            Destroy(gameObject);
        }
    }
}
