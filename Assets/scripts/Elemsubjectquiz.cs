using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Elemsubjectquiz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void elemathQuiz()
    {
        SceneManager.LoadScene("elemmathquiz");
    }
    public void elesciQuiz()
    {
        SceneManager.LoadScene("elemsciquiz");
    }
    public void elecompQuiz()
    {
        SceneManager.LoadScene("elemcompquiz");
    }
    public void hsmathQuiz()
    {
        SceneManager.LoadScene("hsmathquiz");
    }
    public void hssciQuiz()
    {
        SceneManager.LoadScene("hssciquiz");
    }
    public void hscompQuiz()
    {
        SceneManager.LoadScene("hscompquiz");
    }
    public void unicompQuiz()
    {
        SceneManager.LoadScene("unicompquiz");
    }
    public void unisciQuiz()
    {
        SceneManager.LoadScene("unisciquiz");
    }
    public void unimathQuiz()
    {
        SceneManager.LoadScene("unimathquiz");
    }

}

