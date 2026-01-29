using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    public Vector2 movement;

    private void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}