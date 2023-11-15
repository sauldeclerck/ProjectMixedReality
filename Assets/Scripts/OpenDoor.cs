using UnityEngine;
public class OpenDoor : MonoBehaviour
{
    Animator anim;
    bool param;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        param = anim.GetBool("CanOpen");

        if (Input.GetMouseButtonDown(0))
        {
            if (param == false)
            {
                anim.SetBool("CanOpen", true);
            }
            else
            {
                anim.SetBool("CanOpen", false);
            }
        }
    }
}
