using UnityEngine;

public class PlataformaCaida : MonoBehaviour
{
    public float delay = 1f;

    private bool activated = false;

    private Rigidbody rb;

    private Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;

        startPos = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!activated)
        {
            if (collision.gameObject.CompareTag("Player") ||
                collision.gameObject.CompareTag("Bot"))
            {
                activated = true;

                Invoke("Caer", delay);
            }
        }
    }

    void Update()
    {
        if (activated)
        {
            float shakeX = Random.Range(-0.03f, 0.03f);
            float shakeZ = Random.Range(-0.03f, 0.03f);

            transform.position = startPos + new Vector3(shakeX, 0, shakeZ);
        }
    }

    void Caer()
    {
        rb.isKinematic = false;
    }
}