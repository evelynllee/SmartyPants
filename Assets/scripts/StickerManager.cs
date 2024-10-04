using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StickerManager : MonoBehaviour
{
    public int success = 0;

    // References to your sticker panels
    public GameObject stickerv0; // Default or no success panel
    public GameObject stickerv1; // First success panel
    public GameObject stickerv2; // Second success panel
    public GameObject stickerv3; // And so on...
    public GameObject stickerv4;
    public GameObject stickerv5;
    public GameObject GameOverPanel;
    public Text ScoreTxt;

    void Start()
    {
        LoadSuccessCount(); // Load the success count at the start
    }

    // This method simulates a quiz ending and receiving a score
    public void EndQuiz()
    {
        string scoreText = ScoreTxt.text;
        string[] parts = scoreText.Split('/');
        string numerator = "";

        if (parts.Length == 2)
        {
            numerator = parts[0];
        }
    
        int score = int.Parse(numerator); // Parse the text to an integer

        if (score == 5)
        {
            Debug.Log("Congrats, you passed!");
            success++;
            SaveSuccessCount();// Save the success count when it's updated
            DisplayStickerPanel();
        }
        else
        {
            // Logic for not passing the quiz, if any
        }
    }
    // Method to print the number of successes in the terminal
    private void PrintSuccessCount()
    {
        Debug.Log("Total successes: " + success);
    }

    // Method to handle which sticker panel to display based on success count
    private void DisplayStickerPanel()
    {
        // Hide all panels first
        HideAllStickerPanels();

        // Activate the appropriate panel
        GameObject panelToShow = GetCurrentStickerPanel();
        if(panelToShow != null)
        {
            ShowStickerBook();
        }
    }

    // Helper method to hide all sticker panels
    private void HideAllStickerPanels()
    {
        stickerv0.SetActive(false);
        stickerv1.SetActive(false);
        stickerv2.SetActive(false);
        stickerv3.SetActive(false);
        stickerv4.SetActive(false);
        stickerv5.SetActive(false);
    }

    public void ShowStickerBook()
    {
        // Ensure no sticker panels are currently shown
        HideAllStickerPanels();

        // Logic to display the current sticker panel based on successes
        GameObject panelToShow = GetCurrentStickerPanel();
        if(panelToShow != null)
        {
            panelToShow.SetActive(true);
            // Optionally, disable the GameOverPanel if it's visible
            GameOverPanel.SetActive(false);
        }
    }

    // Helper method to get the current sticker panel based on the success count
    private GameObject GetCurrentStickerPanel()
    {

        switch (success)
        {
            case 1: return stickerv0;
            case 2: return stickerv1;
            case 3: return stickerv2;
            case 4: return stickerv3;
            case 5: return stickerv4;
            default: return stickerv5; // Default or no success panel
        }
    }

    private void SaveSuccessCount()
    {
        PlayerPrefs.SetInt("SuccessCount", success);
        PlayerPrefs.Save();
    }

    private void LoadSuccessCount()
    {
        success = PlayerPrefs.GetInt("SuccessCount", 0); // Default to 0 if not set
    }

}