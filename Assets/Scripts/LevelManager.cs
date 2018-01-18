using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel(string levelName)
    {
        print("Loading level " + levelName);
        //Loads the scene name levelName
        SceneManager.LoadScene(levelName);
    }

    public void BrickDestroyed()
    {
        //Calling static variable breakableCOunt
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
