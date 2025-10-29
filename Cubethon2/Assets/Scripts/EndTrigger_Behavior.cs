using UnityEngine;

public class EndTrigger_Behavior : MonoBehaviour
{
    public GameManager _gm;

    private void OnTriggerEnter(Collider other)
    {
        _gm.CompleteLevel();
    }
}
