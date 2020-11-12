using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onInteractableObjectTriggerEnter;
    public void InteractableObjectTriggerEnter()
    {
        onInteractableObjectTriggerEnter?.Invoke();
    }

    public event Action onInteractableObjectTriggerExit;
    public void InteractableObjectTriggerExit()
    {
        onInteractableObjectTriggerExit?.Invoke();
    }



    
}
