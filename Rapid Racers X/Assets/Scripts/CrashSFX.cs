using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSFX : MonoBehaviour {
    public AudioSource audio_c;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Player" && col.gameObject.tag != "MainPlayer")
        { audio_c.Play(); }
    }
}
