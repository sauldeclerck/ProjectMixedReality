using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;
    private Animator animator;
    public bool isWalking = false;
    private Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();

        animator.SetFloat("Speed", movement.magnitude);

        // Update de isWalking eigenschap
        isWalking = movement.magnitude > 0;
        animator.SetBool("isWalking", isWalking);  // Zet de isWalking parameter in de Animator

        // Log de isWalking en Speed eigenschap in de console
        Debug.Log("isWalking: " + isWalking);
        Debug.Log("Speed: " + animator.GetFloat("Speed"));
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();

        Vector3 moveDestination = transform.position + movement * speed * Time.fixedDeltaTime;
        rb.MovePosition(moveDestination);
    }
}
