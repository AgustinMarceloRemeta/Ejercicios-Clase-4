using System;
using UnityEngine;

public class Extra : MonoBehaviour
{
    public int value;
    public string extraName;
    public bool isActive;

    public void Activate()
    {
        isActive = !isActive;
        UiManager.EventUi ?.Invoke();
        ExtraManager.findEvent?.Invoke();
    }
}
