using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    [SerializeField] private float _moveSensitivity;

    private PlayerController playerController;
    private GameManager gameManager; 
    private void Start()
    {
        playerController = PlayerController.Instance;
        gameManager = GameManager.Instance;
    }
    public void OnDrag(PointerEventData eventData)
    {
        float movement = eventData.delta.x;
        playerController.transform.parent.transform.position += new Vector3(movement * _moveSensitivity * Time.deltaTime, 0, 0);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        gameManager.StartTheGame();
    }
}
