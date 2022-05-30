using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public static int level=1;
    CharacterControl control;

    private void Awake()
    {
        control = FindObjectOfType<CharacterControl>();
    }
    public void StartButton()
    {
        SceneManager.LoadScene(level);
    }
    public void RestartButton()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CompleteScene()
    {
        if (level == 3)
        {
            level = 1;
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        level++;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        level = 1;
    }
}
