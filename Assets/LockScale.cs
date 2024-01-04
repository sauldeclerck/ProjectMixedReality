using UnityEngine;

public class LockScale : MonoBehaviour
{
    private Vector3 originalScale;

    void Start()
    {
        // Bewaar de oorspronkelijke schaal bij het starten
        originalScale = transform.localScale;
    }

    void LateUpdate()
    {
        // Pas de Y- en Z-schalen aan om gelijk te blijven aan de oorspronkelijke schaal
        transform.localScale = new Vector3(transform.localScale.x, originalScale.y, originalScale.z);
    }
}
