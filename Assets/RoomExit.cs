using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomExit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GetComponentInParent<Room>().RemoveBullets();
            GetComponentInParent<Room>().LetVCameraFollowPlayer();
        }
    }
}
