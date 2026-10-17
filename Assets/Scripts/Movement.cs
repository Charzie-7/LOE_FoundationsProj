using UnityEngine;


public class Movement : MonoBehaviour
{

    public float movementSpeed = 10f; 
    public float rotationSpeed = 100f;

    /*Rigidbody _rb;
    Vector2 _movements;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _rb = GetComponents<Rigidbody>();
    }

    // Update is called once per frame

    private Void FixedUpdate()
    {
        moveCharachter(_movements);
    }
   
    void moveCharachter(Vector2 direction)
    {
        _rb.AddForce(direction*speed);
    }*/
    void Update()
    {

        //_movements = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime,Space.World);
           
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime,Space.World);
           
        }
       
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-transform.right*movementSpeed*Time.deltaTime,Space.World);
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right*movementSpeed*Time.deltaTime,Space.World);
           
        }


        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(transform.up * rotationSpeed * Time.deltaTime);
        }

         if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate((-1)*transform.up * rotationSpeed * Time.deltaTime);
        }

    }
}
