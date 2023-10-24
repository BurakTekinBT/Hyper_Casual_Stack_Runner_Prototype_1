using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public Transform currentleadTransform;
    public float smoothTime = 0.1f;
    private float _currentVelocity = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") || other.transform.CompareTag("Collectible"))
        {
            Player.Instance.AddToStack(transform);
        }
    }

    private void Update()
    {
        if(currentleadTransform == null)
        {
            return;
        }
        else
        {
            transform.position = new Vector3(Mathf.SmoothDamp
                (transform.position.x, currentleadTransform.position.x, ref _currentVelocity, smoothTime), 
                transform.position.y, 
                transform.position.z);
        }
    }

    public void SetLeadTransform(Transform leadTransform)
    {
        currentleadTransform = leadTransform;
    }
    
}
