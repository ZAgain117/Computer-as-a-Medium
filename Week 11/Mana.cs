using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class Mana : MonoBehaviour


{
    public int mana = 100;
    public TMP_Text manaText;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created\
    
    void Start()
    {
        animator = GetComponent<Animator>();
        manaText.text = "Mana:" + mana;
        animator.SetBool("magic", false);
    
    }


    // Update is called once per frame
    void Update()
    {
        animator.SetBool("magic", false);
        if(Keyboard.current != null && Keyboard.current.gKey.wasPressedThisFrame) 
     {
        Attack();

     }

    }


    void Attack()
    {   
        animator.SetBool("magic", true);
        mana -= 10;
        manaText.text = "Mana:" + mana;
      
        
    }

   
}

