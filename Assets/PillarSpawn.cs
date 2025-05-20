using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawn : MonoBehaviour
{
    public GameObject firstPillar;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        PillarSpawning();
    }

    // Spawning pillar every 1 sec
    private void PillarSpawning()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            float spawnTimer = 1.0f;
            timer = spawnTimer;

            Instantiate(firstPillar, new Vector3(firstPillar.transform.position.x + 4, -(0 + Random.Range(3.8f, 7.6f)), -1), new Quaternion(0, 0, 0, 0));
            Instantiate(firstPillar, new Vector3(firstPillar.transform.position.x + 4, 0 + Random.Range(3.8f, 7.6f), -1), new Quaternion(0, 0, 0, 0));
        }
    }
}
