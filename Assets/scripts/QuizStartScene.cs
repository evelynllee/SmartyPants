using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class QuizStartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startmathQuiz()
    {
        SceneManager.LoadScene("elemmathquizstart");
    }
    public void startsciQuiz()
    {
        SceneManager.LoadScene("elemsciquizstart");
    }
    public void startcompQuiz()
    {
        SceneManager.LoadScene("elemcompquizstart");
    }
    public void starthsmathQuiz()
    {
        SceneManager.LoadScene("hsmathquizstart");
    }
    public void starthssciQuiz()
    {
        SceneManager.LoadScene("hssciquizstart");
    }
    public void starthscompQuiz()
    {
        SceneManager.LoadScene("hscompquizstart");
    }
    public void startunicompQuiz()
    {
        SceneManager.LoadScene("unicompquizstart");
    }
    public void startunimathQuiz()
    {
        SceneManager.LoadScene("unimathquizstart");
    }
    public void startunisciQuiz()
    {
        SceneManager.LoadScene("unisciquizstart");
    }

}
