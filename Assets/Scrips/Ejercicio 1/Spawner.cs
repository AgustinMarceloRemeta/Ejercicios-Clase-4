using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    List<GameObject> weapons;
    [SerializeField] Vector3 spawnPosition;
    [SerializeField] Text textWeapon;
    void Start()
    {
     weapons = new List<GameObject>(Resources.LoadAll<GameObject>("Armas"));
    }

    public void InstanciateNewWeapon()
    {
        foreach (var item in weapons)
        {
            if(item.name == textWeapon.text)
            {
                Destroy(GameObject.FindGameObjectWithTag("Weapon"));
                Instantiate(item, spawnPosition, Quaternion.identity);
                return;
            }    
        }
        Debug.Log("No weapons found");
    }
}
