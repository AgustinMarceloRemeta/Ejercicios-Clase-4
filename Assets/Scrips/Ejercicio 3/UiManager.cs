using System;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Text listExtras;
    public static Action eventUi;

    void Start()
    {
        AsignListExtras();
    }

    public void AsignListExtras()
    {
        listExtras.text = "";
        Extra[] extras = FindObjectsOfType<Extra>();
        for (int i = 0; i < extras.Length; i++)
        {
            listExtras.text += (i+1).ToString() + " " + extras[i].extraName;

            if (extras[i].isActive) listExtras.text += " activo" + "\n";
            else listExtras.text += " desactivado" + "\n";
        }
    }
    private void OnEnable()
    {
        eventUi += AsignListExtras;
    }
    private void OnDisable()
    {
        eventUi -= AsignListExtras;
    }
}
