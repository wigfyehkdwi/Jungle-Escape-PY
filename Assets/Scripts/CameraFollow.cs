using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        //follow player's position with a y and z offset
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 2.5f, player.transform.position.z - 4f);
    }
}
