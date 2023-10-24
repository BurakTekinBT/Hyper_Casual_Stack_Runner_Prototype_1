using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private List<Transform> collectedCubes = new List<Transform>();
    public List<Transform> CollectedCubes { get => collectedCubes; set => collectedCubes = value; }

    private void Awake()
    {
        Instance = this;
    }


    public void AddToStack(Transform obj)
    {
        if (!CollectedCubes.Contains(obj))
        {
            obj.parent = transform.GetChild(2).transform;
            CollectedCubes.Add(obj);
        }
        UpdateList();
    }

    public void UpdateList()
    {
        for (int i = 0; i < collectedCubes.Count; i++)
        {
            if (i == 0)
            {
                collectedCubes[i].transform.position = new Vector3(collectedCubes[i].transform.position.x, collectedCubes[i].transform.position.y, transform.position.z + 1.5f);
                collectedCubes[i].gameObject.GetComponent<CollectibleManager>().SetLeadTransform(transform);
            }
            else
            {
                collectedCubes[i].transform.position = new Vector3(collectedCubes[i].transform.position.x, collectedCubes[i].transform.position.y, collectedCubes[i - 1].transform.position.z + 1.5f);
                collectedCubes[i].GetComponent<CollectibleManager>().SetLeadTransform(collectedCubes[(i - 1)].transform);
            }
        }
    }

}
