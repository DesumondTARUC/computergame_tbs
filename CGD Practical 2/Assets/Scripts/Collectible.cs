using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    GameController gc;
    int gemValue = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

            if (gameObject.name == "Gems - Green Variant")
                gc.changeScore(gemValue * 2);

            else if (gameObject.name == "Gems - Blue Variant")
                gc.changeScore(gemValue * 3);

            else
                gc.changeScore(gemValue);

            Debug.Log("Enter Collider Gem");
        }
    }
}
