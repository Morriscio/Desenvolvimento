using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 5;
    public Rigidbody Rb;
    Vector3 moveVector = Vector3.zero,
            direction = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;

        if (Keyboard.current[Key.W].isPressed == true)
        {
            direction += transform.forward;
        }
        direction = Vector3.ClampMagnitude(direction, 1);
    }

    void FixedUpdate()
    {
        Rb.linearVelocity = new Vector3(direction.x *Speed, Rb.linearVelocity.y, direction.z *Speed);

        // Rb.linearVelocity = moveVector * speed;
    }

    public void OnMove(InputValue value)
    {
        moveVector = new(value.Get<Vector2>().x, Rb.linearVelocity.y, value.Get<Vector2>().y);
    }
}
