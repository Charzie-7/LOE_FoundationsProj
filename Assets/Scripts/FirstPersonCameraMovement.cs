using UnityEngine;

public class FirstPersonCameraMovement : MonoBehaviour
{
   public Transform playerObj;
   public float mouseSensitivity = 2f;
   float cmaeraverticalRotation = 0f;
   //https://docs.unity.com/en-us/engine/6000.6/script-reference/unityengine/cursorlockmode/locked
    // Update is called once per frame
    public void Update ()
    {
         Cursor.lockState = CursorLockMode.Locked;
         //FirstPersonCameraMovement.enable = true;

       

        // the mouse inputs 
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;// mouse horizontal rotation
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;// mouse vertical rotation


        //mouse vertical rotation
        cmaeraverticalRotation -= inputY;
        cmaeraverticalRotation = Mathf.Clamp(cmaeraverticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(cmaeraverticalRotation, 0f, 0f);
        
        playerObj.Rotate(Vector3.up * inputX);
    }
}
