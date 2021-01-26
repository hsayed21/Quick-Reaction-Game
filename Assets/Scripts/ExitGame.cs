using UnityEngine;
using System.Collections;

public class finalScript : MonoBehaviour
{

    public void ExitGame()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }
    public void StartGame()
    {
        //**Note must add every scene to build settings
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
