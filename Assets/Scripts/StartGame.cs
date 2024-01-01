using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartGame : MonoBehaviour
{
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("start");
        SceneManager.LoadScene("AI TestScene");
    }
}
