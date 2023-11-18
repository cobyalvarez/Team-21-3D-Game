using UnityEngine;

public class SphereController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is the plane
        if (other.CompareTag("plane"))
        {
            // Adjust the position or velocity to prevent falling through
            // For example, you can set the Y position to be on the plane
            Vector3 newPosition = transform.position;
            newPosition.y = other.transform.position.y + other.bounds.extents.y + GetComponent<Collider>().bounds.extents.y;
            transform.position = newPosition;

            // You can also stop the sphere's movement
            // GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    // Use OnTriggerStay if you need continuous collision checks
    // private void OnTriggerStay(Collider other)
    // {
    //     // Handle continuous collision
    // }
}