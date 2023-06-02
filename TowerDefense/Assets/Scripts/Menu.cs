using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    [Header("References")]  
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] Animator anim;

    private bool isMenuOpen = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen", isMenuOpen);
    }

    private void OnGUI() 
    {
        currencyUI.text = LevelManager.main.currency.ToString();        
    }

    public void SetSelected()
    { 
    }
}
