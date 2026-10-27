using UnityEngine;

public class ItemsCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    public int partsCollected = 0;
    public void CollectedItem()
    {
        partsCollected++;
        Debug.Log("Parts collected: " + partsCollected);
    }
    void Start()
    {
    
    //if(keyDetectionTrigger.Key1Inserted && keyDetectionTrigger.Key2Inserted && playerDetection.partsCollected == 5)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
