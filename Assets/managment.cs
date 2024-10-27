using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managment : MonoBehaviour
{
    // Start is called before the first frame updat



    public void PlayGame()
    {
SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Application");
    }

}
