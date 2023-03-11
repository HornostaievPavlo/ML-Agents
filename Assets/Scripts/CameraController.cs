using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform hummingBird;

    Vector3 offset = new Vector3(0.25f, 0.25f, 0.25f);

    Camera mainCamera;

    void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if (hummingBird == null) return;

        mainCamera.transform.position = hummingBird.transform.position + offset;

        mainCamera.transform.LookAt(hummingBird);
    }
}
