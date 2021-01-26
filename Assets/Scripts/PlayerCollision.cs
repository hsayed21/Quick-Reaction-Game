using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public Player movement;


    void OnCollisionEnter(Collision info)
    {
        //Debug.Log("Hit Thing");
        //Debug.Log(info.collider.name); // name object obstacle
        //info.collider.tag == "hajz" used for group something as 

        if (info.collider.name == "Obstacle")
        {
            //Debug.Log("hiiiit Obstacle");
            //movement.enabled = false; // stop move if has collision
            //FindObjectOfType<gameManager>().EndGame();
        }
    }
}
