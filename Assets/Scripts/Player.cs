using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


    // Make object from Rigidbody , can edit all attributes
    public Rigidbody rbPlayer;
    public float forwardSpeed = 200;
    public float LR_PowerForce = 500;

	// Use this for initialization
	void Start () {
        // Debug Code
        //Debug.Log("Starting Game");
        // Rigidbody > useGravity 
        //rbPlayer.useGravity = true;
        // Rigidbody > AddForce(x, y, z)
        //rbPlayer.AddForce(0, 200, 500);

	}

    //void FixedUpdate () used with physics more real movement
	// Update is called once per frame
	void Update () {
        //Rb.AddForce(x, y, z * Time.deltaTime); // Time.deltaTime usefull for GPU detect which frame can load
        // Control player with keyboard by [addforce]
        rbPlayer.AddForce(-forwardSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
        {
            rbPlayer.AddForce(0, 0, LR_PowerForce * Time.deltaTime);
        }

        else if (Input.GetKey("a"))
        {
            rbPlayer.AddForce(0, 0, -LR_PowerForce * Time.deltaTime);
        }
        if (rbPlayer.position.y < -1)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
	}
}
