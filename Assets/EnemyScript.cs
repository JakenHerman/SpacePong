using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyPaddle;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        Renderer rend = enemyPaddle.gameObject.GetComponent<Renderer>();
        rend.material.color = Color.green;
        rb = enemyPaddle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }
        else
        {
            Sleep();
        }
    }

    void Move(Vector3 vector)
    {
        rb.velocity = vector * 15;
    }

    void Sleep()
    {
        rb.Sleep();
    }

}
