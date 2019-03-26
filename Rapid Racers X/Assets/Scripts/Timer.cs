using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour {
    public float timeLeft; //set the amount of seconds to complete the level in;
    TextMeshPro x;
    // Use this for initialization
    void Start () {
        x = this.gameObject.GetComponent<TextMeshPro>();
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        x.text = "Time left: " + timeLeft.ToString("F2");
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        FinishLineLevelChanger.carIsfinished = false;
        FinishLineLevelChanger.mainCarFinished = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
