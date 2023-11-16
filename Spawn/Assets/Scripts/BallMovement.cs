using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Move the ball forward along its own forward direction
        Vector3 forwardDirection = transform.forward;
        rb.MovePosition(rb.position + forwardDirection * speed * Time.deltaTime);
    }
}