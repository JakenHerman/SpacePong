using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject playerPaddle;
    public Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
	    Renderer rend = playerPaddle.gameObject.GetComponent<Renderer>();
        rend.material.color = Color.green;
	    rb = playerPaddle.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
	    {
            Move(Vector3.up);
	    }
	    else if (Input.GetKey(KeyCode.S))
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
