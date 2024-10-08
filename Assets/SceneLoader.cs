using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);

    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadSecScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitScene()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

        SceneManager.LoadScene(0);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
