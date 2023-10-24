using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isGameStarted;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        isGameStarted = false;
    }

    public void StartTheGame()
    {
        isGameStarted = true;
    }

}
