using UnityEngine;
//this scrip is to destory an object with space bar

public class PushSpaceToDestroy : MonoBehaviour
{
  
    public GameObject gameObjectToDestroy;// this is the object that will be destroyed when the space bar is pressed
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);// this distroys the objet
            
            //Destroy(this);// this distroys the script

            //Destroy(this.gameObject);// this distroys the objet that the script is attached to

            Destroy(gameObjectToDestroy);// this distroys the object that is assigned to the public variable

        }
    }
}
