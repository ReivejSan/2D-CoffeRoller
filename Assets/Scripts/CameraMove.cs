﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Header("Position")]
    public Transform player;
    public float horizontalOffset;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharMoveController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizontalOffset;
        transform.position = newPosition;
    }
}
