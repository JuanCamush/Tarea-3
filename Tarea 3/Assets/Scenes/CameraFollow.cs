using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0, 5, -8);

    public float followSpeed = 5f;
    public float forwardSpeed = 3f;

    private Vector3 initialRotation;

    void Start()
    {
        // guardar rotación inicial
        initialRotation = transform.eulerAngles;
    }

    void LateUpdate()
    {
        if (player == null) return;

        // avanzar hacia adelante según dirección del jugador
        transform.position += player.forward * forwardSpeed * Time.deltaTime;

        // seguir jugador
        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(
                targetPosition.x,
                targetPosition.y,
                transform.position.z
            ),
            followSpeed * Time.deltaTime
        );

        // mantener rotación fija
        transform.eulerAngles = initialRotation;
    }
}