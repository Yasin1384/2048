using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public int gridSize = 4;
    public float tileSpacing = 1.1f;
    public Vector3 startPosition = Vector3.zero;

    void Start()
    {
        GenerateBoard();
    }

    void GenerateBoard()
    {
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                Vector3 spawnPos = startPosition + new Vector3(x * tileSpacing, y * tileSpacing, 0);
                Instantiate(tilePrefab, spawnPos, Quaternion.identity, transform);
            }
        }
    }
}
