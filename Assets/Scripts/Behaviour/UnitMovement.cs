using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    private UnitController _controller;
    private Rigidbody2D _rigidbody;

    private Vector2 _direction = Vector2.zero;

    private void Awake()
    {
        _controller = GetComponent<UnitController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_direction);
    }

    private void Move(Vector2 direction)
    {
        _direction = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        // 이동 속도
        direction *= 5;

        _rigidbody.velocity = direction;
    }
}
