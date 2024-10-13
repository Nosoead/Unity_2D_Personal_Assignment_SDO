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


    //transform�� ����ü ����ü�� new�� ���ο� �� �ٽ� ��������ߵ� ����.
    private void FollowPlayer()
    {
        playerPosition = playerTransform.position;
        cameraPosition = transform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, cameraPosition.z);
    }
}
