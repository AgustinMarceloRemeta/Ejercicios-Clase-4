using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField] int maxBullets, bullets; 
    [SerializeField] float reloadTime;
    [SerializeField] Text bulletsText;
    bool isReloadind;

    void Start()
    {
        isReloadind = false;
        bullets = maxBullets;
        AsignText();
    }

    private void AsignText()
    {
        bulletsText.text = "Balas: " + bullets;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Shoot();
        if ((bullets <= 0 || Input.GetKeyDown(KeyCode.R)) && bullets< maxBullets && !isReloadind) StartCoroutine(Reload(reloadTime));
    }

    void Shoot()
    {
        if (bullets > 0)
        {
            StopAllCoroutines();
            print("pum");
            bullets--;
            AsignText();
            isReloadind = false;
        }
    }

    IEnumerator Reload(float timeToReturn)
    {
        isReloadind = true;
        yield return new WaitForSeconds(timeToReturn);
        bullets++;
        AsignText();
        print("Bullet++");
        if (bullets < maxBullets) StartCoroutine(Reload(1));
        else isReloadind = false;
    }

}

