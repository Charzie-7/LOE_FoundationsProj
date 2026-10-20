using UnityEngine;

public class InteractionsPIckup : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int Count = 0;

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Destroy(gameObject);
            Count = Count + 1;
        }

        if (Count == 1)
        {
            Debug.Log("You have picked up the item");
        }
        if (Count == 2)
        {
            Debug.Log("You have picked up the item second time");
        }
        if (Count == 3)
        {
            Debug.Log("You have picked up the item third time");
        }
        if (Count == 4)
        {
            Debug.Log("You have picked up the item fourth time");
        }
    }
}
