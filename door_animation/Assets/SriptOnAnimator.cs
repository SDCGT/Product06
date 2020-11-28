using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SriptOnAnimator : MonoBehaviour
{
    Vector3 touchPoint;
    bool animatePlay;
    bool touched;
    public Animator m_animator;
    public ParticleSystem fire;

    private void Update()
    {
        if (animatePlay&touched)
        {
            PlayParticle(touchPoint);
        }
        
    }

    void Spark()
    {
        //Debug.Log("Spark!");
        animatePlay = true;
    }

    void AttackEnd()
    {
        //Debug.Log("AttackEnd");
        animatePlay = false;
    }
    
    void Touch(Vector3 pos)
    {
        Debug.Log("Touch:"+pos);
        touchPoint = pos;
        touched = true;
    }
    void Leave()
    {
        Debug.Log("Leave");
        touched = false;
    }

    void PlayParticle(Vector3 touch)
    {
        Debug.Log("PlayParticle");
        fire.Play();
    }
}
