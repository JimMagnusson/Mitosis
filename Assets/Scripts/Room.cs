using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Room : MonoBehaviour
{

    public GameObject spikesUp;
    public GameObject spikesDown;
    private bool roomCleared = false;
    private int numberOfEnemiesRemaining;
    public GameObject virtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemiesRemaining = GetComponentsInChildren<Enemy>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfEnemiesRemaining <= 0)
        {
            SpikesUp();
            roomCleared = true;
        }
    }

    public void ReduceNumberOfEnemiesRemaining()
    {
        numberOfEnemiesRemaining -= 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !roomCleared)
        {
            SpikesDown();
            CenterCameraInRoom();
        }
    }

    private void SpikesDown()
    {
        spikesDown.GetComponent<Collider2D>().enabled = true;
        spikesDown.GetComponent<Animator>().SetTrigger("spikesDown");
        spikesUp.GetComponent<Collider2D>().enabled = true;
        spikesUp.GetComponent<Animator>().SetTrigger("spikesDown");
    }

    private void SpikesUp()
    {
        spikesDown.GetComponent<Collider2D>().enabled = false;
        spikesDown.GetComponent<Animator>().SetTrigger("spikesUp");
        spikesUp.GetComponent<Collider2D>().enabled = false;
        spikesUp.GetComponent<Animator>().SetTrigger("spikesUp");
    }

    public void RemoveBullets()
    {
        Bullet[] bulletScripts = FindObjectsOfType<Bullet>();
        for(int i = 0; i < bulletScripts.Length; i++)
        {
            Destroy(bulletScripts[i].gameObject);
        }
    }

    public void LetVCameraFollowPlayer()
    {
        virtualCamera.GetComponent<CinemachineVirtualCamera>().m_Follow = FindObjectOfType<Player>().gameObject.transform;
    }

    private void CenterCameraInRoom()
    {
        virtualCamera.GetComponent<CinemachineVirtualCamera>().m_Follow = transform;
    }

}
