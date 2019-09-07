using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour {

    public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        ball.GetComponent<Rigidbody>().useGravity = true;

    }
}
