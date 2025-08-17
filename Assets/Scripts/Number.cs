using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number
{
    public Text numberTileText;

    public void GameDatas(GameObject tileGameObjects, int numberTileText)
    {
        this.numberTileText.text = numberTileText.ToString();
    }
}
