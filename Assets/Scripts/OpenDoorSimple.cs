using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenDoorSimple : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        anim.SetBool("CanOpen", true);

    }

    public void OnHoverExited(HoverExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} stopped hovering over {args.interactableObject}", this);
    }
}
