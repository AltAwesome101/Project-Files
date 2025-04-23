using UnityEngine;
using UnityEngine.UI;

// Will Display the Simplest FlowChart for our Game

public class IntroScreenManager : MonoBehaviour 
{
    public GameObject introUI;

    private bool introActive = false;
    void Update() 
    {
        if (introActive && Input.GetKeyDown(KeyCode.Return)) 
        {
            if (introUI != null) 
            {
                introUI.SetActive(false);
                Time.timeScale = 1f;
                introActive = false;
            }
        }
    }
}