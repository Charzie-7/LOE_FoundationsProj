using UnityEngine;

public class LeafFiveCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public ItemsCollected itemsCollected;
    public GameObject clickObjToDestroy;
    public void CollectedItem()
    {
    itemsCollected.CollectedItem();
    
    }
    void OnMouseDown()
    {
    Destroy(clickObjToDestroy);
    CollectedItem();
    }
   
    void Update()
    {
        
    }
}
