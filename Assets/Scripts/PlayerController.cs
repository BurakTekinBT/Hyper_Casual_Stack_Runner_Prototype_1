using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public float _playerSpeed;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            transform.parent.transform.position += Vector3.forward * _playerSpeed * Time.deltaTime;
        }
    }
    private void OnDrag()
    {
        
    }
}
