using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool Correct = false;
    public QuizManager quizManager;


    public void Answer()
    {
        if(Correct)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();

        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong();

        }
    }   
}
