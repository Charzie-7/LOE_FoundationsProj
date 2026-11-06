using UnityEngine;

public class LeafOneCollect : MonoBehaviour

{
    Animator animator;
    public ItemsCollected itemsCollected;
     
    public GameObject Leaf2;
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
        Leaf2.SetActive(false);
    }
    void Update()
    {
    
    }
}
