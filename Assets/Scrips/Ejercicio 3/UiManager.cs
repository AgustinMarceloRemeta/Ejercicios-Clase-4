using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Text ListExtras;
    public static Action EventUi;

    void Start()
    {
        ListExtras.text = "";
        AsignListExtras();
    }

    public void AsignListExtras()
    {
        ListExtras.text = "";
        Extra[] extras = FindObjectsOfType<Extra>();
        for (int i = 0; i < extras.Length; i++)
        {
            ListExtras.text += (i+1).ToString() + " " + extras[i].extraName;
            if (extras[i].isActive) ListExtras.text += " activo" + "\n";
            else ListExtras.text += " desactivado" + "\n";
        }
    }
    private void OnEnable()
    {
        EventUi += AsignListExtras;
    }
    private void OnDisable()
    {
        EventUi -= AsignListExtras;
    }
}
