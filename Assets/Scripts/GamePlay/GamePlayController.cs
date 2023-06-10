using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController Instance;
    public GameUI gameScene;
    public PlayerController playerController;
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Init()
    {
        gameScene.Init();
    }
}
