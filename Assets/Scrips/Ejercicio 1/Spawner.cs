using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    List<GameObject> weapons;
    [SerializeField] Vector3 spawnPosition;
    [SerializeField] string defaultObject;
    [SerializeField] Text textWeapon;
    void Start()
    {
     weapons = new List<GameObject>(Resources.LoadAll<GameObject>("Armas"));
    }

    public void FindNewWeapon()
    {
        foreach (var item in weapons)
        {
            if(item.name == textWeapon.text.ToLower())
            {
                InstanciateObject(item);
                return;
            }    
        }
      
        Debug.Log(textWeapon.text+ " was not found, spawning " + defaultObject);
        GameObject spawnDefault = weapons.Find(item => item.name == defaultObject);
        InstanciateObject(spawnDefault);
    }
    public void InstanciateObject(GameObject spawnObject)
    {
        Destroy(GameObject.FindGameObjectWithTag("Weapon"));
        Instantiate(spawnObject, spawnPosition, Quaternion.identity);
        return;
    }
}
