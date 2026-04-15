using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offsetX = 5f;
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        Vector3 targetPos = new Vector3(
            player.position.x + offsetX,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
    }
}