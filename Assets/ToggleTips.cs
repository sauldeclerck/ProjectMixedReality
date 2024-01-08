using UnityEngine;

public class ToggleTips : MonoBehaviour
{
    public GameObject tipsToToggle;
    public Transform playerCamera;
    public float distanceFromPlayer = 2.0f;
    public float leftOffsetDistance = 0.5f;

    public void Toggle()
    {
        if (tipsToToggle != null)
        {
            bool isActive = !tipsToToggle.activeSelf;
            tipsToToggle.SetActive(isActive);

            if (isActive)
            {
                PositionPlanInFrontOfPlayer();
            }
        }
    }

    void PositionPlanInFrontOfPlayer()
    {
        if (playerCamera == null) return;

        Vector3 positionInFront = playerCamera.position + playerCamera.forward * distanceFromPlayer;


        Vector3 leftOffset = -playerCamera.right * leftOffsetDistance;


        tipsToToggle.transform.position = positionInFront + leftOffset;

        tipsToToggle.transform.rotation = Quaternion.LookRotation(playerCamera.forward);

    }
    void Start()
    {
        tipsToToggle.SetActive(false);
    }

}
