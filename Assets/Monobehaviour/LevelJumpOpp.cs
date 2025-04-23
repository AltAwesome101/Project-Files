using UnityEngine;

// Goes to the Level Named Accordingly
public class LevelJumpOpp : MonoBehaviour 
{
    public string targetSceneName;
    private void OnTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            if (!string.IsNullOrEmpty(targetSceneName)) 
            {
                SceneChange.instance.LoadScene(targetSceneName);
            }
        }
    }
}
