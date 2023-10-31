using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject board;
    public GameObject pieceOprefab;
    public GameObject pieceXprefab;
    public GameObject pieceBox;
    [System.NonSerialized]
    public GameObject gameController;

    private void Start()
    {
        gameController = gameObject;
    }
}
