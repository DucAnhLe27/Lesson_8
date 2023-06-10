using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Button changeSkinBtn;

    // Start is called before the first frame update
    public void Init()
    {
        //changeSkinBtn.onClick.AddListener(ChangeSkinPlayer);
    }

    // Update is called once per frame
    void ChangeSkinPlayer()
    {
        var dataSkins = GameController.Instance.dataManager.skinData.skins;
        var playerControl = GamePlayController.Instance.playerController;
        //int randomSkin = Random.Range(0, dataSkins.Count);
        playerControl.baseSkin.material = dataSkins[0].skinMaterial;
        playerControl.hatSkin.material = dataSkins[0].skinMaterial;
    }
}
