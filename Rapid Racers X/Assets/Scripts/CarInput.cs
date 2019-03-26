using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarMovement))]
public class CarInput : MonoBehaviour {

    CarMovement M;

    private void Awake()
    {
        M = GetComponent<CarMovement>();
    }
    
    protected void SteerDir (float steer)
    {
        M.SteeringDir(steer);
    }
    
    protected void EngineDir (float direction)
    {
        M.engineForce(direction);
    }
}
