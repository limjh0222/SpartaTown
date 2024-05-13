using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private GameObject _player;
    private Vector3 _cameraPositionZ = new Vector3(0, 0, -10);

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        transform.position = _player.transform.position + _cameraPositionZ;
    }
}