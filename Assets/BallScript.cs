using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BallScript : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;

    public GameObject RightPaddle;

    public bool _reset;

    public Text playerLeftScoreText;
    public Text playerRightScoreText;

    public bool playerLeftScored;
    public bool playerRightScored;

    public int playerLeftScore = 0;
    public int playerRightScore = 0;

    public float thrust;

    // Use this for initialization
    void Start()
    {
        Renderer rend = ball.gameObject.GetComponent<Renderer>();
        rend.material.color = Color.white;
        _reset = true;
        bool chooseFirstPlayer = (Random.value > 0.5f);
        if (chooseFirstPlayer)
        {
            playerLeftScored = true;
            playerRightScored = false;
        }
        else
        {
            playerRightScored = true;
            playerLeftScored = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_reset)
        {
            if (Input.GetKeyDown(KeyCode.Space) && playerLeftScored)
            {
                playerLeftScored = false;
                rb = ball.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(1, (float)-0.5, 0) * thrust;
                _reset = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && playerRightScored)
            {
                playerRightScored = false;
                rb = ball.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(-1, (float)0.5, 0) * thrust;
                _reset = false;
            }
        }
        else
        {
            if (ball.transform.position.x <= -9.5)
            {
                playerRightScore++;
                playerRightScored = true;
                playerRightScoreText.text = playerRightScore.ToString();
                StartOver();
            }
            else if (ball.transform.position.x >= 9.5)
            {
                playerLeftScore++;
                playerLeftScored = true;
                playerLeftScoreText.text = playerLeftScore.ToString();
                StartOver();
            }
        }
    }

    void StartOver()
    {
        ball.transform.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        RightPaddle.transform.position = new Vector3(9, 0, 0);
        Rigidbody re = RightPaddle.gameObject.GetComponent<Rigidbody>();
        re.velocity = Vector3.zero;
        _reset = true;
    }
}
