using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField] int maxBullets,bullets;
    [SerializeField] Text bulletsText;
    bool isReload;
    void Start()
    {
        isReload = false;
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
        if ((bullets <= 0 || Input.GetKeyDown("r")) && bullets< maxBullets && !isReload) StartCoroutine(Reload(1));
    }

    void Shoot()
    {
        if (bullets > 0)
        {
            StopAllCoroutines();
            print("pum");
            bullets--;
            AsignText();
            isReload = false;
        }
    }
    IEnumerator Reload(float timeToReturn)
    {
        isReload = true;
        yield return new WaitForSeconds(timeToReturn);
        bullets++;
        AsignText();
        print("Bullet++");
        if (bullets < maxBullets) StartCoroutine(Reload(1));
        else isReload = false;
    }
}
