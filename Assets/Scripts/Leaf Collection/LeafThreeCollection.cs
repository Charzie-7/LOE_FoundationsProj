using UnityEngine;

public class LeafThreeCollection : MonoBehaviour
{
    Animator animator;
    public ItemsCollected itemsCollected;
     
    public GameObject Leaf3;
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
        Leaf3.SetActive(false);
    }
    void Update()
    {
    
    }
}
