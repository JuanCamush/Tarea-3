using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform directionPoint;

    public float speed = 5f;

    void Update()
    {
        Vector3 direction = (directionPoint.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;
    }
}