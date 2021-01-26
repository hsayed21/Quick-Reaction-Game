using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    
    bool gameEnd = false;  // Check if reach to trigger point
    public Player movement;
    public Rigidbody rbPlayer;
    //public float restDelay = 1;
    public GameObject levelComplete;


    // if level complete
    public void GameComplete()
    {
        Debug.Log("You Win");
        movement.enabled = false;
        rbPlayer.velocity = Vector3.zero;
        //rbPlayer.AddForce(300 * Time.deltaTime, 0, 0);
        //completeLevel.SetActive(true);

    }

    // if failed | level not complete
    public void EndGame()
    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            //Restart();
            //Invoke("Restart", restDelay); // Delay when Game over show restart 
        }

    }

    //public void Restart()
    //{
    //    // restart scene if game over
    //    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
