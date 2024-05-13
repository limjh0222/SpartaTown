using System;
using UnityEngine;

public class UnitAim : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _characterRenderer;

    private UnitController _controller;

    private void Awake()
    {
        _controller = GetComponent<UnitController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        // 마우스 각도
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // 마우스 각도에 따른 캐릭터 뒤집기(좌, 우)
        _characterRenderer.flipX = Mathf.Abs(rotZ) > 90.0f;
    }
}
