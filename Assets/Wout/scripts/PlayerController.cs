using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 2.0f; // Snelheid van de speler
    private Animator animator; // Animator component
    public bool isWalking = false; // Nieuwe isWalking eigenschap

    void Start()
    {
        // Verkrijg de Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Verkrijg input van de speler
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Bepaal de bewegingsrichting
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();

        // Verplaats de speler
        transform.Translate(movement * Speed * Time.deltaTime, Space.World);

        // Update de Speed parameter in de Animator
        animator.SetFloat("Speed", movement.magnitude);

        // Update de isWalking eigenschap
        isWalking = movement.magnitude > 0;
        animator.SetBool("isWalking", isWalking);  // Zet de isWalking parameter in de Animator
    }
}
