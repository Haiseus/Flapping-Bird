using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSpawn : MonoBehaviour
{
    public GameObject spear;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        SpearSpawning();
    }

    // Spawning spear every 1 sec
    private void SpearSpawning()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            float spawnTimer = 1.0f;
            timer = spawnTimer;

            Instantiate(spear, new Vector3(spear.transform.position.x + 4, 0 + Random.Range(5.25f, 8f), -1), new Quaternion(0, 0, 180, 0));
            Instantiate(spear, new Vector3(spear.transform.position.x + 4, -(0 + Random.Range(5.25f, 8f)), -1), new Quaternion(0, 0, 0, 0));
        }
    }
}
