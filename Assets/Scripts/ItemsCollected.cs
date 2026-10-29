using UnityEngine;

public class ItemsCollected : MonoBehaviour
{
    public GameObject treebush1;
    public GameObject treebush2;
    public GameObject bushtree3;
    public GameObject bushtree4;



    public int partsCollected = 0;
    public void CollectedItem()
    {
        partsCollected++;// this will add 1 to the parts collected when the item is clicked on to keep collected
        Debug.Log("Parts collected: " + partsCollected);
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if(partsCollected == 2) 
    {
        treebush1.SetActive(true);// this will make the object appear when the parts collected is equal to 2
    
    }
        if(partsCollected == 4)
    {
        treebush2.SetActive(true);
    
    }
    if(partsCollected == 5)
    {
        bushtree3.SetActive(true);
        
    }
    if(partsCollected == 6)
    {
        bushtree4.SetActive(true);
        
    }
}
}
