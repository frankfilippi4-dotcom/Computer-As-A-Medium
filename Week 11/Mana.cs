using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class Mana : MonoBehaviour
// Script for Mana
{
    public Animator animator;
    public int mana = 100;
    public TMP_Text manaText;

    private void Update()
    {
        animator.SetBool("attack", Keyboard.current.rKey.isPressed);
        if (Keyboard.current.rKey.wasPressedThisFrame)
        { mana -= 10; }
        { manaText.text = "Mana: " + mana; }
    }
}

