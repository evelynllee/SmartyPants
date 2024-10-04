using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToGO : MonoBehaviour
{
    public GameObject stickerv0; // Default or no success panel
    public GameObject stickerv1; // First success panel
    public GameObject stickerv2; // Second success panel
    public GameObject stickerv3; // And so on...
    public GameObject stickerv4;
    public GameObject stickerv5;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        stickerv0.SetActive(false);
        stickerv1.SetActive(false);
        stickerv2.SetActive(false);
        stickerv3.SetActive(false);
        stickerv4.SetActive(false);
        stickerv5.SetActive(false);
        GameOverPanel.SetActive(true);
        
    }

}
