using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    public float thrust;

	// Use this for initialization
	void Start ()
	{
	    Renderer rend = ball.gameObject.GetComponent<Renderer>();
	    rend.material.color = Color.white;

        rb = ball.GetComponent<Rigidbody>();
	    rb.velocity = Vector3.right * thrust;
    }
	
	// Update is called once per frame
	void Update () {

    }

}
