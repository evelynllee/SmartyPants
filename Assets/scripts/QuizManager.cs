using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GameOverPanel;

    public Text QuestionTxt;
    public Text ScoreTxt;
    int TotalQ = 0;
    public int score;
    public Button StickerBookButton;
    public Button RetryButton;
    


    // Success tracking and sticker panels
    private int success = 0;

    private void Start()
    {
        TotalQ = QnA.Count;
        GameOverPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        ScoreTxt.text = score + "/" + TotalQ;

        // If the score is less than 5, show the Retry Button
        if (score < 5)
        {
            RetryButton.gameObject.SetActive(true);
            StickerBookButton.gameObject.SetActive(false); // Make sure this is explicitly set to false here.
        }
        else
        {
            // For scores of 5/5, hide the Retry Button
            RetryButton.gameObject.SetActive(false);
            
            // Assuming success increases and you show the sticker book or other success related UI
            success++;
            // Update: Hide or show the StickerBookButton based on specific conditions
            StickerBookButton.gameObject.SetActive(score == 5); // This will only show it for a perfect score
        }
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
     public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().Correct = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<Answers>().Correct = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            setAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
    }

}
