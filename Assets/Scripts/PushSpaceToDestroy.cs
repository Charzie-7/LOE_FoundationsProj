using UnityEngine;
//this scrip is to destory an object with space bar

public class PushSpaceToDestroy : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
