using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{

    private GameObject box;
    private const float positonOffset = 10f / 3f;
    private const float height = 2f / 3f;
    void Start()
    {
        box = FindAnyObjectByType<GameController>().pieceBox;
        for (int x = -1; x < 2; x++)
            for(int z = -1; z < 2; z++)
            {
                GameObject ret = Instantiate(box, new Vector3(positonOffset * x, height, positonOffset * z), Quaternion.identity);
                ret.transform.parent = gameObject.transform;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
