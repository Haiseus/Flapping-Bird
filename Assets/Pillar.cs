using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public float pillarSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * pillarSpeed * Time.deltaTime;
    }
}