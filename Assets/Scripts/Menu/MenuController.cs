using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button btnPlay;

    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(ChangeToSceneGameplay);
    }

    void ChangeToSceneGameplay()
    {
        SceneManager.LoadScene(SceneName.GAME_PLAY, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
