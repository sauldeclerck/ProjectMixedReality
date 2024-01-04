using UnityEngine;

public class TogglePlan : MonoBehaviour
{
    public GameObject planToToggle;
    public Transform playerCamera; // Referentie naar de camera van de speler
    public float distanceFromPlayer = 2.0f; // Afstand voor de speler waar het plan verschijnt
    public float leftOffsetDistance = 0.5f; // Afstand naar links van de speler

    public void Toggle()
    {
        if (planToToggle != null)
        {
            bool isActive = !planToToggle.activeSelf;
            planToToggle.SetActive(isActive);

            if (isActive)
            {
                PositionPlanInFrontOfPlayer();
            }
        }
    }

    void PositionPlanInFrontOfPlayer()
    {
        if (playerCamera == null) return;

        // Bereken de positie recht voor de speler
        Vector3 positionInFront = playerCamera.position + playerCamera.forward * distanceFromPlayer;

        // Bereken de zijwaartse verschuiving naar links
        Vector3 leftOffset = -playerCamera.right * leftOffsetDistance;

        // Stel de positie van het bouwplan in
        planToToggle.transform.position = positionInFront + leftOffset;

        // Optioneel: pas de rotatie aan zodat het plan naar de speler 'kijkt'
        planToToggle.transform.rotation = Quaternion.LookRotation(playerCamera.forward);

        // Stel de schaal van het bouwplan in (indien nodig)
        // Bijvoorbeeld: planToToggle.transform.localScale = new Vector3(1, 1, 1);
    }
    void Start()
    {
        planToToggle.SetActive(false);
    }

}
