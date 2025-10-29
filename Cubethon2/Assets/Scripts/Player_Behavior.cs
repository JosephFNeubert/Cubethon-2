using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    public Rigidbody _rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            forwardForce = 0;
            sidewaysForce = 0;
            FindFirstObjectByType<GameManager>().GameOver();
        }
    }

    private void FixedUpdate()
    {
        _rb.AddForce(forwardForce * Time.deltaTime * -1, 0, 0);

        if (Input.GetKey("d"))
        {
            _rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            _rb.AddForce(0, 0, sidewaysForce * Time.deltaTime * -1, ForceMode.VelocityChange);
        }

        if (_rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().GameOver();
        }
    }
}
