using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animController;  // Assign in Inspector or find dynamically

    void Start()
    {
        if (animController == null)
        {
            animController = GetComponent<Animator>();  // Ensure Animator is assigned
        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            animController.SetBool("isTouching", true);
        }
    }

    
}

