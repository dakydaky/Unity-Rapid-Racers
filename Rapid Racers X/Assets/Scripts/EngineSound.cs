using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour {
    Rigidbody2D x;
    AudioSource mAudio;
	// Use this for initialization
	void Start () {
        x = this.gameObject.GetComponent<Rigidbody2D>();
        mAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if(x.velocity.magnitude >=0.2)
        {
            if(!mAudio.isPlaying)
            {
            mAudio.Stop();
            mAudio.volume = 0.2f;
            mAudio.Play();
            }
        }
        else
        {
            mAudio.Stop();
        }

    }
}
