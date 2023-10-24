using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Target Section")]
    [SerializeField] private Transform target;
    Vector3 targetPosition;
    private Vector3 distanceTarget;

    [Header("Camera Section")]
    Vector3 cameraPosition;
    private float speed;

    void Start()
    {
        speed = PlayerController.Instance._playerSpeed;
        cameraPosition = transform.position;
        targetPosition = target.position;
        distanceTarget = targetPosition - cameraPosition;
    }

    void Update()
    {
        FollowCamera();
    }

    void FollowCamera()
    {
        transform.position = Vector3.Lerp(transform.position, target.position - distanceTarget, speed * Time.deltaTime);
    }
}
