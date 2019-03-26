using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartHandler : MonoBehaviour {
	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            FinishLineLevelChanger.carIsfinished = false;
            FinishLineLevelChanger.mainCarFinished = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
