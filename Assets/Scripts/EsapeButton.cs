using UnityEngine;
using UnityEngine.SceneManagement;
public class EsapeButton : MonoBehaviour
{
public EnableAndDisable Disable;
public GameObject playerObj;
public GameObject PausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Disable();
            Time.timeScale = 0;
            PausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
