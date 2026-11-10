using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // https://youtu.be/DX7HyN7oJjE?is=l6RBd8jhM3WljHg1
    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void playIntro()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void mainMenu()
    {
        SceneManager.LoadSceneAsync(2);
    }
    
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }

    public void EndGame()
    {
        
        SceneManager.LoadSceneAsync(3);
    }

    public void EndGame2()
    {
        
        SceneManager.LoadSceneAsync(4);
    }
    
}

