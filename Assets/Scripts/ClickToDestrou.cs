
using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Debug.Log("Object was clicked");
        //Debug.LogError("Object was clicked");//This log error will stop play mode 
        //Debug.LogWarning("Object was clicked"); //This log warning will not stop play mode
        Destroy(clickObjToDestroy);


      
    }
    
}
