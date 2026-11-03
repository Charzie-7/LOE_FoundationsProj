using UnityEngine;

public class enableScript : MonoBehaviour
{
    public FirstPersonCameraMovement FirstPersonCameraMovement;
     public void enableCamera()
    {
         FirstPersonCameraMovement.enabled = true;
         Time.timeScale = 1;
    }

    public void Pausestartup()
    {
        Time.timeScale = 1;
    }
}
