using UnityEngine;

public class LeafOneCollect : MonoBehaviour

{

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
