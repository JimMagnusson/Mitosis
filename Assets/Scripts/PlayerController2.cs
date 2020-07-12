using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public float rotationSpeed = 5;
    private PrefabFactory pf = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pf = GetComponent(typeof(PrefabFactory)) as PrefabFactory;
    }

    // Update is called once per frame
    void Update()
    {
        HelpFunctions.MoveTheThing(rb, Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), speed);
        
        
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ - 90);

        if(Input.GetMouseButtonDown(0)) {
            pf.SpawnPrefabAtLocation("Bullet", GameObject.Find("BulletSpawn").transform.position, transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Room")
        {
            //Camera.main.transform.position.x = transform.position.x;
            //Camera.main.transform.position.y = transform.position.y;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Room")
        {
            //Camera.main.transform.position.x = transform.position.x;
            //Camera.main.transform.position.y = transform.position.y;
        }
    }
}
