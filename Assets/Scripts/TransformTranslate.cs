using UnityEngine;

public class TransformTranslate : MonoBehaviour
{



    public float movementSpeed = 10.0f; 
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {
            /* if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0,0,10);
            Debug.Log("S Key Pressed");
        }

             if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0,0,-10);
            Debug.Log("W Key Pressed");
        }

           if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(10,0,0);
            Debug.Log("D Key Pressed");
        }
           if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-10,0,0);
            Debug.Log("A Key Pressed");
        }

         if (Input.GetAxis("mouse x") < 0)
        {
            transform.Translate(-10,0,0);
            Debug.Log("A Key Pressed");
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
           
        }
       
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-transform.right*movementSpeed*Time.deltaTime);
           
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(transform.up * movementSpeed * Time.deltaTime);
           
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate((-1)*transform.up * movementSpeed * Time.deltaTime);
        }

    }
}
