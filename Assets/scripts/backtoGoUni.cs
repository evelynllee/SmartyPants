using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToGoUni : MonoBehaviour
{
    public GameObject sticker0; // Default or no success panel
    public GameObject sticker1; // First success panel
    public GameObject sticker2; // Second success panel
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
        sticker0.SetActive(false);
        sticker1.SetActive(false);
        sticker2.SetActive(false);
        GameOverPanel.SetActive(true);
        
    }

}
