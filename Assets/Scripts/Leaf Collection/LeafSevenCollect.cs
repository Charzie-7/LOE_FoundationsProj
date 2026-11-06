using UnityEngine;

public class LeafSevenCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   Animator animator;
    public ItemsCollected itemsCollected;
     
    public GameObject Leaf7;
    public void CollectedItem()
    {
    itemsCollected.CollectedItem();
    
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
    animator.SetBool("IsClicked",true);
    //Destroy(clickObjToDestroy);// the item will disappear when clicked on
    

    CollectedItem();
    }
    void Completed()
    {
        Leaf7.SetActive(false);
    }
    void Update()
    {
    
    }
}
