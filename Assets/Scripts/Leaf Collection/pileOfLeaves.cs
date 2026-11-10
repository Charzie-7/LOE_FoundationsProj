using UnityEngine;
using UnityEngine.SceneManagement;
public class pileOfLeaves : MonoBehaviour
{

 public GameObject clickObjToDestroy;
    void OnMouseDown()
    {
    Destroy(clickObjToDestroy);
    SceneManager.LoadSceneAsync(4);
    
    }
}
