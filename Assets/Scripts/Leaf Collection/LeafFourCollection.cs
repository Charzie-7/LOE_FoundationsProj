using UnityEngine;

public class LeafFourCollection : MonoBehaviour
{
  Animator animator;
    public ItemsCollected itemsCollected;
     
    public GameObject Leaf4;
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
        Leaf4.SetActive(false);
    }
    void Update()
    {
    
    }
}
