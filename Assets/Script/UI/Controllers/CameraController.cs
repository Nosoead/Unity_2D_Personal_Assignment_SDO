using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 playerPosition = Vector3.zero;
    private Vector3 cameraPosition = Vector3.zero;

    // Update is called once per frame
    private void FixedUpdate()
    {
        FollowPlayer();
    }


    //transform은 구조체 구조체는 new로 새로운 값 다시 설정해줘야됨 공부.
    private void FollowPlayer()
    {
        playerPosition = playerTransform.position;
        cameraPosition = transform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, cameraPosition.z);
    }
}
