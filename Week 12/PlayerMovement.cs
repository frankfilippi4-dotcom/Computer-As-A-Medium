using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Transform weapon;

    public SpriteRenderer spriteRenderer;
    public Sprite beartop;
    public Sprite beardown;
    public Sprite bearleft;
    public Sprite bearright;

    private float speedX;
    private float speedY;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // Horizontal movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = bearleft;
            weapon.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = bearright;
            weapon.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }
        else
        {
            speedX = 0f;
        }

        // Vertical movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = beartop;
            weapon.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = beardown;
            weapon.localRotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else
        {
            speedY = 0f;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
