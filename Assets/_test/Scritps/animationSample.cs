using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSample : MonoBehaviour
{
     private Animator m_Animator;
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            m_Animator.SetTrigger("Cheering");
        else if (Input.GetKeyDown(KeyCode.W))
            m_Animator.SetTrigger("Walking With Shopping Bag");
        else if (Input.GetKeyDown(KeyCode.E))
            m_Animator.SetTrigger("Victory Idle");
        else if (Input.GetKeyDown(KeyCode.R))
            m_Animator.SetTrigger("Pointing");
        else if (Input.GetKeyDown(KeyCode.T))
            m_Animator.SetTrigger("Waving");
        else if (Input.GetKeyDown(KeyCode.Y))
            m_Animator.SetTrigger("Left Turn");
        else if (Input.GetKeyDown(KeyCode.U))
            m_Animator.SetTrigger("Standard Walk");
        else if (Input.GetKeyDown(KeyCode.I))
            m_Animator.SetTrigger("Right Turn");
        else if (Input.GetKeyDown(KeyCode.O))
            m_Animator.SetTrigger("Joyful Jump");
        else if (Input.GetKeyDown(KeyCode.P))
            m_Animator.SetTrigger("Clapping");
        else if (Input.GetKeyDown(KeyCode.B))
            m_Animator.SetTrigger("Back idle");
    }
}
