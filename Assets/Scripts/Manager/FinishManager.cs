using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        int cubeCount = Player.Instance.CollectedCubes.Count;
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Ýçeri girdi");
            for(int i = 0; i < cubeCount; i++)
            {
                Destroy(other.transform.GetChild(2).transform.GetChild(i).gameObject);               
            }           
        }
    }
}
