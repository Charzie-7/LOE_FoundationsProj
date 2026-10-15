using UnityEngine;
//this script is for a debug log statement 
public class HelloWorldDebug : MonoBehaviour
{


    void OnEnable()
    {
        Debug.Log("Hello World");
    }

    void OnDisable()
    {
        Debug.Log("Goodbye World");
    }

}
