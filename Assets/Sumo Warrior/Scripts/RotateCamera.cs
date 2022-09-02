using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(axis: Vector3.up, angle: horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
