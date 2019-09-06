using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {

    public Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("tab"))
        {
            if (light.color == Color.white)
                light.color = Color.red;
            else
                light.color = Color.white;
        }
	}
}
