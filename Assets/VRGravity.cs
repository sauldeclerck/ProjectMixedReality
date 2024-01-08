using UnityEngine;

public class VRGravity : MonoBehaviour
{
    private CharacterController characterController;
    public float gravity = -9.81f; // Zwaartekrachtwaarde
    private Vector3 velocity; // Snelheid van de val
    public Transform groundCheck; // Een transform op de voeten van de speler
    public float groundDistance = 0.4f; // Afstand om te checken of de speler op de grond is
    public LayerMask groundMask; // Mask om de grond te detecteren
    bool isGrounded;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Kleine waarde om te zorgen dat de speler op de grond 'plakt'
        }

        velocity.y += gravity * Time.deltaTime; // Pas zwaartekracht toe
        characterController.Move(velocity * Time.deltaTime); // Voer de beweging uit
    }
}
