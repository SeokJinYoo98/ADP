using UnityEngine;

public class UnitController : MonoBehaviour
{
    private InputReader _input;
    private Rigidbody2D _rb;

    private Vector2 _moveInput;

    public void Construct(InputReader input)
    {
        _input = input;
        _rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = _input.Move;
    }
    private void FixedUpdate()
    {
        _rb.linearVelocity = _moveInput;
    }
}
