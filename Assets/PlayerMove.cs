using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody Rb;
    Vector3 moveVector = Vector3.zero;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
            Rb.linearVelocity = moveVector * speed;
    }

    public void OnMove(InputValue value)
    {
        moveVector = new(value.Get<Vector2>().x, Rb.linearVelocity.y, value.Get<Vector2>().y);
    }
}
