using UnityEngine;
using UnityEngine.SceneManagement;
public class ItemsCollected : MonoBehaviour
{

    public FirstPersonCameraMovement FirstPersonCameraMovement;

    //defining all the game objects that will be used to show the parts collected and the objects that will appear when the parts are collected
    public GameObject treebush1;
    public GameObject treebush2;
    public GameObject bushtree3;
    public GameObject bushtree4;
    public GameObject treebush5;

    public GameObject Tick1;
    public GameObject Tick2;
    public GameObject Tick3;
    public GameObject Tick4;
    public GameObject Tick5;
    public GameObject Tick6;
    public GameObject Tick7;


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
        if(partsCollected==1)
    {
        Tick1.SetActive(true);
    }

        if(partsCollected == 2) 
    {
        treebush1.SetActive(true);// this will make the object appear when the parts collected is equal to 2
        Tick2.SetActive(true);
    }

        if(partsCollected == 3)
    {
        Tick3.SetActive(true);
    }

        if(partsCollected == 4)
    {
        treebush2.SetActive(true);
        Tick4.SetActive(true);
    
    }
    if(partsCollected == 5)
    {
        bushtree3.SetActive(true);
        Tick5.SetActive(true);
        
    }
    if(partsCollected == 6)
    {
        bushtree4.SetActive(true);
        Tick6.SetActive(true);
        
    }
    if(partsCollected == 7)
    {
        treebush5.SetActive(true);
        Tick7.SetActive(true);
        FirstPersonCameraMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        SceneManager.LoadSceneAsync(3);// this will load the end scene when all the parts are collected
        //cursor.visible = true;
    }
}
}
