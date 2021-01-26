using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{

    // Use this for initialization
    public void LoadNextLevel()
    {
        // Load new level
        Debug.Log("New Level");
        //FindObjectOfType<gameManager>().Restart();
        // first add scenes to build settings 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
