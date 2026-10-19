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

        _movement = new Vector3(Input.GetAxisRaw("HorizontalX"), Input.GetAxisRaw("HorizontalY"));

    
    }
        void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + (Vector3)_movement * movementSpeed * Time.fixedDeltaTime);
    }
}


