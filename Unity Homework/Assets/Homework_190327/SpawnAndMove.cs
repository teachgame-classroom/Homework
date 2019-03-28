using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndMove : MonoBehaviour
{
    private GameObject playerPrefab;
    private GameObject player;

    void Start()
    {
        playerPrefab =  Resources.Load<GameObject>("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player = (GameObject)Instantiate(playerPrefab, Vector3.up, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += player.transform.forward * 10 * Time.deltaTime;
        }
    }
}
