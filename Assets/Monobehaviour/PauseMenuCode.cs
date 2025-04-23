using UnityEngine;

// PauseMenu Code With Quit Build Button Working!
public class PauseMenuCode : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    private bool isPaused = false;

    void Start()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;     
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Settings()
    {
       // No Settings in Prototype
    }
    public void Quit()
    {
        Application.Quit();
    }
}

