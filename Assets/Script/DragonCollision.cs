using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D spear)
    {
        if (spear.gameObject.CompareTag("Border"))
        {
            Debug.Log("Game Over");
        }
    }
}
