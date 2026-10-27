using UnityEngine;

public class InteractionsPIckup : MonoBehaviour
{
    
    
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
    Destroy(clickObjToDestroy);

    Destroy(clickObjToDestroy);
    
    Destroy(clickObjToDestroy);
    }
    void Update()
    {
       
    }
}
