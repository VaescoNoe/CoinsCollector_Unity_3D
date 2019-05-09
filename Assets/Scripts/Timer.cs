using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float maxTime = 60.0f;

    private float countDown = 0.0f;

	// Use this for initialization
	void Start () {
        countDown = maxTime;

    }

    // Update is called once per frame
    void Update() {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            Coin.coinsCount = 0;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
