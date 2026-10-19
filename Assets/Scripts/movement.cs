using UnityEngine;

public class movement : MonoBehaviour
{
    
   
    public float rotationSpeed;
    Vector2 _movement;
    Rigidbody _rb;
    public float movementSpeed = 5f;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        _movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

       
    }
        void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector3(_movement.x, 0f, _movement.y) * movementSpeed * Time.fixedDeltaTime);
    
    
    }


}


