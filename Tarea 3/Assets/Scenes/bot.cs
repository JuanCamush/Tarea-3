using UnityEngine;

public class Bot : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 6f;

    private Rigidbody rb;
    private Animator anim;

    public Transform groundCheck;
    public float checkDistance = 2f;

    private bool grounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // avanzar
        rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);

        // animación correr
        anim.SetFloat("Speed", speed);
        anim.SetFloat("MotionSpeed", 1f);

        // detectar piso adelante
        RaycastHit hit;

        Vector3 origin = groundCheck.position;

        bool groundAhead = Physics.Raycast(
            origin,
            Vector3.down,
            out hit,
            checkDistance
        );

        // si no hay piso adelante → saltar
        if (!groundAhead && grounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        grounded = false;

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        anim.SetTrigger("Jump");
    }

    void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
}