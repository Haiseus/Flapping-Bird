using System.Collections;
using System.Collections.Generic;
using AnimatedBattleText.Examples;
using UnityEngine;

public class DragonCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D spear)
    {
        if (spear.gameObject.CompareTag("Border"))
        {
            Debug.Log("GAME OVER");
            GameManager.Instance.PauseGame();
            GameManager.Instance.gameOverUI.SetActive(true);
            GameManager.Instance.DisplayKO();
        }
    }
}
