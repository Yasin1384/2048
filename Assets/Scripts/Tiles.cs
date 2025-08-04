using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiles : MonoBehaviour
{

    public GameObject tileGameObjects;
    public Text numberTileText;

    public void GameDatas(GameObject tileGameObjects, int numberTileText)
    {
        this.tileGameObjects = tileGameObjects;
        this.numberTileText.text = numberTileText.ToString();
    }
}
