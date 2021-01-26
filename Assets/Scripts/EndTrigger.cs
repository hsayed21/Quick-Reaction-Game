using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour {

    public gameManager manager; // object from class gameManager


    // Trigger for End Level or something
    void OnTriggerEnter()
    {
        // must select box as Trigger in Box Collider
        manager.GameComplete(); // called method GameComplete
    }
}
