using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player movement
    private Vector2 moveInput; // Stores the input direction from WASD

    private PlayerInput controls;

    public void Awake()
    {
        controls = new PlayerInput();
    }

    void OnEnable()
    {
        controls.Enable();

        controls.Player.Movement.performed += _PlayerInput;
        controls.Player.Movement.canceled += _PlayerInput;
    }

    

    private void OnDisable()
    {
        controls.Disable();

        controls.Player.Movement.performed -= _PlayerInput;
        controls.Player.Movement.canceled -= _PlayerInput; 
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void _PlayerInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }

    public void MovePlayer()
    {
        Vector2 movement = moveInput.normalized;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }


}
