using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public float spearSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * spearSpeed * Time.deltaTime;
    }
}
