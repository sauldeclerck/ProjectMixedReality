using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EndGame : MonoBehaviour
{
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Application.Quit();
    }
}
