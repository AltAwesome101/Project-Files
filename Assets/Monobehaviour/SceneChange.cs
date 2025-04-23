using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

// Joins Levels Together Without Loading Screen
public class SceneChange : MonoBehaviour 
{
    public static SceneChange instance;
    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    public void LoadScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void NextLevel() 
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings) 
        {
            SceneManager.LoadScene(nextIndex);
        }
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) 
    {
        int index = scene.buildIndex;

        if(index == 1 || index == 2 || index == 0) 
        {
            RPGGameManager gameManager = FindObjectOfType<RPGGameManager>();

            if (gameManager != null) 
            {
                gameManager.SetupScene();
            }
        }
    }
}