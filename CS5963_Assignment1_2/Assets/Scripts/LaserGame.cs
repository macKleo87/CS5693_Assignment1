using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserGame : MonoBehaviour {

    public Light light_red;  //1
    public Light light_green; //2
    public Light light_blue;  //3
    public Light light_purple; //4

    public BoxCollider box_red;
    public BoxCollider box_green;
    public BoxCollider box_blue;
    public BoxCollider box_purple;

    System.Random rnd = new System.Random();

    public float waitTime = 5.0f;
    public float timeElapsed = 0.0f;

    public Text score;

    int currentLight = 1;
    int scoreNum = 0;

	// Use this for initialization
	void Start () {
		
	}

    void turnAllOff()
    {
        light_red.enabled = false;
        light_blue.enabled = false;
        light_green.enabled = false;
        light_purple.enabled = false;
    }

    void OnTriggerStay(Collider box)
    {
        if(box == box_red && currentLight == 1 && Input.GetButtonDown("XBox_A"))
        {
            scoreNum++;
            score.text = scoreNum.ToString();
            timeElapsed = waitTime;
        }
        else if (box == box_green && currentLight == 2 && Input.GetButtonDown("XBox_A"))
        {
            scoreNum++;
            score.text = scoreNum.ToString();
            timeElapsed = waitTime;
        }
        else if (box == box_blue && currentLight == 3 && Input.GetButtonDown("XBox_A"))
        {
            scoreNum++;
            score.text = scoreNum.ToString();
            timeElapsed = waitTime;
        }
        else if (box == box_purple && currentLight == 4 && Input.GetButtonDown("XBox_A"))
        {
            scoreNum++;
            score.text = scoreNum.ToString();
            timeElapsed = waitTime;
        }
    }

    // Update is called once per frame
    void Update () {
        timeElapsed += Time.deltaTime;
        
        if (timeElapsed >= waitTime)
        {
            //change light
            turnAllOff();

            int newLight = rnd.Next(1, 5);

            while(newLight == currentLight)
            {
                newLight = rnd.Next(1, 5);
            }

            if(newLight == 1)
            {
                light_red.enabled = true;
            }
            else if (newLight == 2)
            {
                light_green.enabled = true;
            }
            else if (newLight == 3)
            {
                light_blue.enabled = true;
            }
            else if (newLight == 4)
            {
                light_purple.enabled = true;
            }
            currentLight = newLight;
            timeElapsed = 0.0f;
        }

        if (Input.GetButtonDown("XBox_Start"))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
