using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarKey : CarInput {

	// Update is called once per frame
	void Update () {
        UpdateSteer();
        UpdatePower();
	}

    void UpdateSteer()
    {
        SteerDir(-Input.GetAxisRaw("Horizontal"));
    }

    void UpdatePower()
    {
        EngineDir(Input.GetAxisRaw("Vertical"));
    }
}
