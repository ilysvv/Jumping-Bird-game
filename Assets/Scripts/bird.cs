using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D MyRigidbody2D;
    public Logic logic;
    public float upForce = 5f;
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            MyRigidbody2D.velocity = Vector2.up * upForce;
        }
        if ((transform.position.y >= 12 || transform.position.y <= -12) && isAlive)
        {
            logic.GameOver();
            isAlive = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        isAlive = false;
    }
}
