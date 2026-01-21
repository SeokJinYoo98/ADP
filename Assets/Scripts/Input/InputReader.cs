using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    public Vector2 Move { get; private set; }

    private GameInputActions _actions;
    private void Awake()
    {
        _actions = new GameInputActions();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 하드코딩 제거해야함.
        _actions.Enable();
        _actions.Player.Move.performed  += OnMove;
        _actions.Player.Move.canceled   += OnMove;
    }
    private void OnDisable()
    {
        _actions.Player.Move.performed -= OnMove;
        _actions.Player.Move.canceled  -= OnMove;
        _actions.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMove(InputAction.CallbackContext ctx) 
        => Move = ctx.ReadValue<Vector2>(); 
}
