using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FinishLineLevelChanger : MonoBehaviour {
    public int carNum;
    public TextMeshPro x;
    public AudioSource audio_c;
    public static bool carIsfinished = false;
    public static bool mainCarFinished = false;
    int i = 0;

	// Use this for initialization
	void Start () {
        x.text = "Cars needed: " + carNum.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "MainPlayer")
        {
            i++;
            carIsfinished = true;
            if(other.gameObject.tag == "MainPlayer") { mainCarFinished = true; }
            CarMovement k = other.gameObject.GetComponent<CarMovement>();  
            k.acceleration = 0;
            k.maxSteer = 0;
            other.GetComponent<SpriteRenderer>().color = Color.green;
            audio_c.Play();
            other.gameObject.tag = "x";
            x.text = "Cars needed: " + (carNum - i).ToString();
            if (i>=carNum)
            {
            carIsfinished = false;
            mainCarFinished = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
