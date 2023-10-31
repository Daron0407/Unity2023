using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointCotrols : MonoBehaviour
{
    private float spawnCooldownMin = .8f;
    private float spawnCooldownMax = 2f;
    private float spawnChance = .5f;
    private float progress = 0f;
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress -= Time.deltaTime;
        if(progress <= 0f)
        {
            progress = Random.Range(spawnCooldownMin, spawnCooldownMax);
            attemptSpawn();
        }

    }

    void attemptSpawn()
    {
        if(Random.Range(0f,1f) < spawnChance)
        {
            Instantiate(prefab, transform);
        }
    }
}
