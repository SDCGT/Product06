using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOnSward : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pos;
    public GameObject AnimatorOnIt;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "stone")
        {
            ContactPoint contact = collision.contacts[0];
            pos = contact.point;
            //Debug.Log("UnityIsShit");
            AnimatorOnIt.SendMessage("Touch", pos);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "stone")
        {
            AnimatorOnIt.SendMessage("Leave");
        }
    }
}
