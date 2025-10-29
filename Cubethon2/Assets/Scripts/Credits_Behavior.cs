using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_Behavior : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
