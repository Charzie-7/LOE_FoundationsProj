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
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        _movement = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxisRaw("Horizontal");
    }
        void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector3(_movement.x, 0f, _movement.z) * movementSpeed * Time.fixedDeltaTime);
    
    
    }


}


