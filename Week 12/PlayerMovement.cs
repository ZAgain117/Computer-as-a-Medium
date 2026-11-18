using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    public GameObject Weapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            Weapon.transform.eulerAngles = new Vector3(0, 0, 0);
            Weapon.transform.localScale = new Vector3(-1f, 1f, 1f);
            speedX = -moveSpeed;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Weapon.transform.eulerAngles = new Vector3(0, 0, 0);
            Weapon.transform.localScale = new Vector3(1f, 1f, 1f);
            speedX = moveSpeed;
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            Weapon.transform.eulerAngles = new Vector3(0, 0, 90);
            Weapon.transform.localScale = new Vector3(1f, 1f, 1f);
 
            speedY = moveSpeed;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Weapon.transform.eulerAngles = new Vector3(0, 0, -90);
            Weapon.transform.localScale = new Vector3(1f, 1f, 1f);
            speedY = -moveSpeed;
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
