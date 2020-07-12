using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private PrefabFactory pf = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HelpFunctions.MoveTheThing(rb, transform.up, speed);
        pf = GetComponent(typeof(PrefabFactory)) as PrefabFactory;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            pf.SpawnPrefabAtLocation("Bullet", collision.gameObject.transform.position, (transform.rotation * Quaternion.Euler(0f, 0f, 90)));
            pf.SpawnPrefabAtLocation("Bullet", collision.gameObject.transform.position, (transform.rotation * Quaternion.Euler(0f, 0f, -90)));
        }
    }
}
