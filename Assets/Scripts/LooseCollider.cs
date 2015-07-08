using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

    private LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D trigger)
    {
        //print("Trigger");
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Loose");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
