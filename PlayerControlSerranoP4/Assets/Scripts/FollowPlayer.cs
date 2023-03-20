using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(30, 1, 0);

    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}