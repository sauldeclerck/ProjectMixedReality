using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject objectToToggle;
    public Transform playerCamera; // Voeg een verwijzing naar de camera van de speler toe
    public float distanceFromPlayer = 2.0f; // De afstand voor de speler waar het object zal verschijnen

    public void Toggle()
    {
        if (objectToToggle != null)
        {
            bool isActive = !objectToToggle.activeSelf;
            objectToToggle.SetActive(isActive);

            if (isActive)
            {
                PositionObjectInFrontOfPlayer();
            }
        }
    }

    void PositionObjectInFrontOfPlayer()
    {
        if (playerCamera == null) return;

        // Bereken de positie recht voor de speler
        Vector3 positionInFront = playerCamera.position + playerCamera.forward * distanceFromPlayer;

        // Bereken de zijwaartse verschuiving (naar links)
        Vector3 leftOffset = -playerCamera.right * 0.5f; // 0.5 eenheden naar links

        // Stel de positie en rotatie van de meetlat in
        objectToToggle.transform.position = positionInFront + leftOffset;

        // Optioneel: pas de rotatie aan zodat de meetlat naar de speler 'kijkt'
        objectToToggle.transform.rotation = Quaternion.LookRotation(playerCamera.forward);

        // Stel de X-schaal van de meetlat in op 1
        Vector3 currentScale = objectToToggle.transform.localScale;
        objectToToggle.transform.localScale = new Vector3(1, currentScale.y, currentScale.z);
    }
    void Start()
    {
        objectToToggle.SetActive(false);
    }


}
