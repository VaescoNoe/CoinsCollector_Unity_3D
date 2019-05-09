using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public static int coinsCount = 0;


	// Use this for initialization
	void Start () {
        Coin.coinsCount++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnDestroy()
    {
        Coin.coinsCount--;
        if (Coin.coinsCount <= 0)
        {
            Debug.Log("El juego ha terminado");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    } 
} 
