using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandbrakeMechanic : MonoBehaviour {
    CarMovement x;
    float a;
    float b;
    float c;

    // Use this for initialization
    void Start () {
        x = this.gameObject.GetComponent<CarMovement>();

        a = x.acceleration;
        b = x.maxSpeed;
        c = x.maxSteer;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            x.acceleration = 0;
            x.maxSpeed = 1000;
            x.maxSteer = 10;
        }
        else
        {
            if(!FinishLineLevelChanger.mainCarFinished)
            { 
            x.acceleration = a;
            x.maxSpeed = b;
            x.maxSteer = c;
            }
        }
    }
}
