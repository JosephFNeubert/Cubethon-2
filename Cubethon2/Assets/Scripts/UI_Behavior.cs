using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Behavior : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    private float score;
    void Update()
    {
        score = player.position.x * -1;
        scoreText.text = score.ToString("0");
    }
}
