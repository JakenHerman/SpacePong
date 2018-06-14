using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallScript : MonoBehaviour
{

    public int playerRightScore = 0;
    public GameObject Left;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().name == "Ball")
        {
            playerRightScore++;
        }
    }
}
