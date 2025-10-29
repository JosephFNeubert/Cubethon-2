using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete_Behavior : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
