using System;
using UnityEngine;

public class ExtraManager : MonoBehaviour
{
    public static Action<int> extraEvent;
    public static Action findEvent;
    Extra[] extras; 

    private void Start()
    {
        extras = FindObjectsOfType<Extra>();
    }

    void FindExtras()
    {
        int value = 0;
        
        foreach (var item in extras)
        {
            if (item.isActive) value += item.value;  
        }
        extraEvent?.Invoke(value);
    }

    private void OnEnable()
    {
        findEvent += FindExtras;
    }

    private void OnDisable()
    {
        findEvent -= FindExtras;
    }

}
