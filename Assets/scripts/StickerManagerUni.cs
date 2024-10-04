using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StickerManagerUni : MonoBehaviour
{
    public int successU = 0;

    // References to your sticker panels
    public GameObject sticker0; // Default or no success panel
    public GameObject sticker1; // First success panel
    public GameObject sticker2; // Second success panel
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
            successU++;
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
        Debug.Log("Total successes: " + successU);
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
        sticker0.SetActive(false);
        sticker1.SetActive(false);
        sticker2.SetActive(false);
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

        switch (successU)
        {
            case 1: return sticker0;
            case 2: return sticker1;
            default: return sticker2; // Default or no success panel
        }
    }

    private void SaveSuccessCount()
    {
        PlayerPrefs.SetInt("SuccessCount", successU);
        PlayerPrefs.Save();
    }

    private void LoadSuccessCount()
    {
        successU = PlayerPrefs.GetInt("SuccessCount", 0); // Default to 0 if not set
    }

}