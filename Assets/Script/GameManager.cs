using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelBattleText;
using TMPro;

namespace AnimatedBattleText.Examples
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        [SerializeField] public GameObject startMenu; // Reference to the start menu UI
        [SerializeField] public GameObject gameOverUI;
        public bool isGameOver = false; // Game over state
        public bool isGamePaused = false; // Game paused state
        private Vector3 textSpawnPosition = new Vector3(0.5f, 0.65f, 0);

        public TextAnimation koAnimation;

        // public Color[] outlineColors;
        public void DisplayKO()
        {
            PixelBattleTextController.DisplayText(
                "KO",
                koAnimation,
                textSpawnPosition
            );
        }
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject); // Keep this object across scenes
            }
            else
            {
                Destroy(gameObject); // Ensure only one instance exists
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            PauseGame();
            startMenu.SetActive(true); // Show the start menu
            textSpawnPosition = new Vector3(0.5f, 0.65f, 0);
        }

        public void PauseGame()
        {
            Time.timeScale = 0f; // Pause the game
        }

        public void ResumeGame()
        {
            Time.timeScale = 1f;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && startMenu.activeSelf)
            {
                startMenu.SetActive(false);
                ResumeGame();
            }
        }
    }
}