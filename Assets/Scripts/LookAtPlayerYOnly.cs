using UnityEngine;

public class LookAtPlayerYOnly : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction to the player
            Vector3 directionToPlayer = player.position - transform.position;
            directionToPlayer.y = 0; // Keep the y-axis rotation unchanged

            // Update the character's rotation to face the player
            Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Euler(0, lookRotation.eulerAngles.y, 0);
        }
    }
}
