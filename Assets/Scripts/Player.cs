using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            StartCoroutine(DeathCoroutine());
            SceneManager.LoadScene(0);
        }
    }

    private IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(2);
    }

}
