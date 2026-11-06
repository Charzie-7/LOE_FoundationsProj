using UnityEngine;

public class LeafSixCollect : MonoBehaviour
{
     Animator animator;
    public ItemsCollected itemsCollected;
     
    public GameObject Leaf6;
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
        Leaf6.SetActive(false);
    }
    void Update()
    {
    
    }
}
