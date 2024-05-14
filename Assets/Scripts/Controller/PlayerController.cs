using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : UnitController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // WASD 입력을 정규화하고 받기
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // 마우스 위치를 월드포지션으로 변환 후
        Vector2 aim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(aim);
        // 마우스 위치 - 캐릭터 위치 = 마우스 벡터
        aim = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(aim);
    }
}
