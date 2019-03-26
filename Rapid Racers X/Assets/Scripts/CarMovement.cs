using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public float maxSpeed;
    public float maxSteer;
    public float reverse;
    public float reverseP;
    public float acceleration;
    public float deceleration;

    float speed = 1f;
    float tSpeed = 0f;
    float steering = 0f;

    Rigidbody2D rb;

    // Use this for initialization

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        updateEnginePower();
    }

    void updateEnginePower()
    {
        float acc = acceleration;

        if(tSpeed == 0f)
        {
            acc = deceleration;
        }
        speed = Mathf.MoveTowards(speed, tSpeed, acc * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Engine();
        Steering();
    }
    // Update is called once per frame
    void Engine () {
        float speedf = maxSpeed;
        if(speed < 0f)
        {
            speedf = reverse;
        }
        rb.AddForce(transform.up * speed * maxSpeed, ForceMode2D.Force);
    }

    void Steering()
    {
        rb.AddTorque(steering * maxSteer, ForceMode2D.Force);
    }

    public void engineForce( float engine)
    {
        tSpeed = Mathf.Clamp(engine, -1, 1f);
    }
    
    public void SteeringDir (float steer )
    {
        steering = Mathf.Clamp(steer, -1, 1f);
    }
}
