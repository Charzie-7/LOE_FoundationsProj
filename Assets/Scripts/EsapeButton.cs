using UnityEngine;
using UnityEngine.SceneManagement;
public class EsapeButton : MonoBehaviour
{

    //https://learn.unity.com/tutorial/enabling-and-disabling-components
public FirstPersonCameraMovement FirstPersonCameraMovement;
public GameObject PausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            FirstPersonCameraMovement.enabled = false;
            Time.timeScale = 0;
            PausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
