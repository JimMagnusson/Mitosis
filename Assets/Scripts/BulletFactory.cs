using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    private GameObject bullet = GameObject.Find("Bullet");
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(bullet, transform);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bullet, transform);
    }
}
