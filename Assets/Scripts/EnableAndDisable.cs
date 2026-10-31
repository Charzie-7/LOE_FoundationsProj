using UnityEngine;

public class EnableAndDisable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Disable()
    {
        this.GetComponent<FirstPersonCameraMovement>.enable=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
