using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void playIntro()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void mainMenu()
    {
        SceneManager.LoadSceneAsync(3);
    }
    
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }

    public void EndGame()
    {
        SceneManager.LoadSceneAsync(4);
    }
    
}

