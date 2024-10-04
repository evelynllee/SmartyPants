using UnityEngine;
using TMPro; // Make sure to include this for TextMeshPro
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 150; // Timer set to 150 seconds
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText; // The timer's text element
    public GameObject GOPanel; // Reference to the Game Over Panel
    public GameObject GamePanel; // Reference to the main game UI panel
    public Button StickerBookButton;


    private void Start()
    {
        timerIsRunning = true;
        GOPanel.SetActive(false); // Ensure the Game Over Panel is initially hidden
        // No need to hide the GamePanel here since it should be visible at the start
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GOPanel.SetActive(true); // Show the Game Over Panel
                GamePanel.SetActive(false); // Hide the Game Panel
                StickerBookButton.gameObject.SetActive(false);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeText == null) {
            Debug.LogWarning("Time TextMeshProUGUI component is not assigned in the inspector.");
            return;
        }

        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
