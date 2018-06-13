using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour {

    public GameObject Top;
    public GameObject Left;
    public GameObject Bottom;
    public GameObject Right;

    // Use this for initialization
    void Start () {
        Renderer left_rend = Left.gameObject.GetComponent<Renderer>();
        left_rend.material.color = Color.white;

        Renderer top_rend = Top.gameObject.GetComponent<Renderer>();
        top_rend.material.color = Color.white;

        Renderer bottom_rend = Bottom.gameObject.GetComponent<Renderer>();
        bottom_rend.material.color = Color.white;

        Renderer right_rend = Right.gameObject.GetComponent<Renderer>();
        right_rend.material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        //check if ball colliding with left or right walls to 
        //calculate score
	}
}
