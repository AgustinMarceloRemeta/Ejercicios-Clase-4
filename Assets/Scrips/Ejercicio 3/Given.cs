using UnityEngine;
using UnityEngine.UI;

public class Given : MonoBehaviour
{
    [SerializeField] int maxGiven;
    int bonus;
    [SerializeField]Text numberGiven, numberGivenExtra;

    public void ThrowGiven()
    {
        int givenNumber = UnityEngine.Random.Range(1, maxGiven + 1);
        numberGiven.text = givenNumber.ToString();
        givenNumber += bonus;
        numberGivenExtra.text = givenNumber.ToString();
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
