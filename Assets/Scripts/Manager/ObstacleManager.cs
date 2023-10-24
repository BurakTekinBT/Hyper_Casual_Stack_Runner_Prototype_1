using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private TextMeshPro stackCountTextUI;
    private int stackCount = 0;

    private void Start()
    {
        UpdateStackText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") && Player.Instance.CollectedCubes.Count == -1)
        {
            Debug.Log("You died");
        }
        if (other.transform.CompareTag("Collectible"))
        {
            stackCount++;
            Destroy(other.gameObject);
            Player.Instance.CollectedCubes.Remove(other.transform);
            UpdateStackText();
            Player.Instance.UpdateList();
        }
    }

    void UpdateStackText()
    {
        stackCountTextUI.text = stackCount.ToString();
    }
}
