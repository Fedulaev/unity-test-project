using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float _speed;
    protected Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    protected virtual void Move()
    {
        //Keyboard movement
        var HorizontalInput = Input.GetAxisRaw("Horizontal");
        var VerticalInput = Input.GetAxisRaw("Vertical");
        _rb.linearVelocity = new Vector2(HorizontalInput, VerticalInput).normalized * _speed;
    }
}
