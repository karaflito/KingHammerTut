using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player movement
    private Vector2 moveInput; // Stores the input direction from WASD








    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void PlayerInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }

    public void MovePlayer()
    {
        Vector2 movement = moveInput.normalized;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }


}
