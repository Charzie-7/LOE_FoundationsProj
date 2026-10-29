using UnityEngine;

public class ItemsCollected : MonoBehaviour
{
    public GameObject treebush1;
    public GameObject treebush2;
    public GameObject bushtree3;
    public GameObject bushtree4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

// object name. set active =("false") to make it disappear.

    public int partsCollected = 0;
    public void CollectedItem()
    {
        partsCollected++;
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
        treebush1.SetActive(true);
    
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
