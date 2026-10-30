using UnityEngine;
using UnityEngine.SceneManagement;
public class EsapeButton : MonoBehaviour
{

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Application.Quit();
            SceneManager.LoadSceneAsync(3);
        }
    }
}
