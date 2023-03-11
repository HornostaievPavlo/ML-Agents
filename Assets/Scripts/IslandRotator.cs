using UnityEngine;

public class IslandRotator : MonoBehaviour
{
    Vector3 rotationVector = new Vector3(0f, 0.035f, 0f);

    void Update()
    {
        transform.Rotate(rotationVector);
    }
}
