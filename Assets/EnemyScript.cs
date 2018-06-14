using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyPaddle;

    public Rigidbody rb;
    public bool ballInSight;
    public Collider col;

    // Use this for initialization
    void Start()
    {
        Renderer rend = enemyPaddle.gameObject.GetComponent<Renderer>();
        rend.material.color = Color.green;
        rb = enemyPaddle.GetComponent<Rigidbody>();
        ballInSight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ballInSight)
        {

            if (col.transform.position.y > enemyPaddle.transform.position.y)
            {
                Move(Vector3.up);
            }
            else if (col.transform.position.y < enemyPaddle.transform.position.y)
            {
                Move(Vector3.down);
            }
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

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().name == "Ball")
        {
            ballInSight = true;
            this.col = col;
            if (col.transform.position.y > enemyPaddle.transform.position.y)
            {
                Move(Vector3.up);
            }
            else if (col.transform.position.y < enemyPaddle.transform.position.y)
            {
                Move(Vector3.down);
            }
            else
            {
                Sleep();
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        ballInSight = false;
    }

}
