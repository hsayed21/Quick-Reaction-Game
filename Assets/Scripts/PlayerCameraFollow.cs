using UnityEngine;
using System.Collections;

public class PlayerCameraFollow : MonoBehaviour {

    // make object from Transform
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
