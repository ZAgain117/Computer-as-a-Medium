using UnityEngine;
using UnityEngine.InputSystem;

public class BearSprite : MonoBehaviour
{
   [Header("BearSprites")]
    public Sprite bear_up;
    public Sprite bear_down;
    public Sprite bear_left;
    public Sprite bear_right;

    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.wKey.wasPressedThisFrame) 
        {
            spriteRenderer.sprite = bear_up;
        }
        if(Keyboard.current.aKey.wasPressedThisFrame) 
        {
            spriteRenderer.sprite = bear_left;
        }
        if(Keyboard.current.sKey.wasPressedThisFrame)
        {
            spriteRenderer.sprite = bear_down;
        }
        if(Keyboard.current.dKey.wasPressedThisFrame) 
        {
            spriteRenderer.sprite = bear_right ;
        }
    }
}
