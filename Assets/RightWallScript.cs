using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallScript : MonoBehaviour
{

    public int playerLeftScore = 0;
    public GameObject Right;

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
            playerLeftScore++;
        }
    }
}
