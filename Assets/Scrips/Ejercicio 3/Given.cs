using UnityEngine;
using UnityEngine.UI;
using System;

public class Given : MonoBehaviour
{
    [SerializeField] int MaxGiven;
    int bonus;
    [SerializeField]Text NumberGiven, NumberGivenExtra;

    public void ThrowGiven()
    {
        int givenNumber = UnityEngine.Random.Range(1, MaxGiven + 1);
        NumberGiven.text = givenNumber.ToString();
        givenNumber += bonus;
        NumberGivenExtra.text = givenNumber.ToString();
    }
    void SetBonus(int newBonus)
    {
        bonus = newBonus;
    }
    private void OnEnable()
    {
        ExtraManager.extraEvent += SetBonus;
    }
    private void OnDisable()
    {
        ExtraManager.extraEvent -= SetBonus;
    }
}
