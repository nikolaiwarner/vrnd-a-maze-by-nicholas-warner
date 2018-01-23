﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Quaternion rotation = Quaternion.Euler(-90, 0, 0);
        Instantiate(coinPoof, transform.position, rotation);
        Destroy(gameObject);
    }

}
