using UnityEngine;

public class Gravity : MonoBehaviour
{
   void OnMouseDown()
    {
        Debug.Log("Mouse Clicked");
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
