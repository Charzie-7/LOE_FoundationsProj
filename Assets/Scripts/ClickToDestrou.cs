
using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Destroy(clickObjToDestroy);
      


      
    }
    
}
