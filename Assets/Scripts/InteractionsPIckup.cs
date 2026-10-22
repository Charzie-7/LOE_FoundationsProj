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
        int Count = 0;

        /*if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(clickObjToDestroy);
            Count = Count + 1;
            Destroy(clickObjToDestroy);
            Count = Count + 1;
            Destroy(clickObjToDestroy);
            Count = Count + 1;
            
        }*/

        if (Count == 1)
        {
            Debug.Log("You have picked up the item");
        }
        if (Count == 2)
        {
            Debug.Log("You have picked up the item second time");
        }
        if (Count == 3)
        {
            Debug.Log("You have picked up the item third time");
        }
        if (Count == 4)
        {
            Debug.Log("You have picked up the item fourth time");
        }
    }
}
