using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu_Behavior : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
}
