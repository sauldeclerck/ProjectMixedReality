using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCanvasOnClick : MonoBehaviour
{
    // This method will be used to disable the Canvas component
    public void DisableCanvas(GameObject parentObject)
    {
        Canvas canvas = parentObject.GetComponentInChildren<Canvas>();
        if (canvas != null)
        {
            canvas.enabled = false;
        }
    }
}
