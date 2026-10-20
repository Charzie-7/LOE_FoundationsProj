using UnityEngine;

public class movement : MonoBehaviour
{
    
   //https://novusxdev.medium.com/day-04-transform-translate-vs-rigidbody-1697f6a0d1a1
    public float rotationSpeed;
    Vector3 _movement;
    Rigidbody _rb;
    public float movementSpeed = 5f;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        _movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));

       
    }
        void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector3(_movement.x, 0f, _movement.z) * movementSpeed * Time.fixedDeltaTime);
    
    
    }


}


