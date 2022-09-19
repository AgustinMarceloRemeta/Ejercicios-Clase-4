using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] int maxBullets,bullets;
    bool isReload;
    void Start()
    {
        isReload = false;
        bullets = maxBullets;
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
            isReload = false;
        }
    }
    IEnumerator Reload(float timeToReturn)
    {
        isReload = true;
        yield return new WaitForSeconds(timeToReturn);
        bullets++;
        print("Bullet++");
        if (bullets < maxBullets) StartCoroutine(Reload(1));
        else isReload = false;
    }
}
