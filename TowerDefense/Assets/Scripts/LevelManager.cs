using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public Transform[] path;
    public Transform startPoint;

    public int currency;


    private void Awake() 
    {
        main = this;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        currency = 100;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if(amount <= currency)
        {
            //buy item
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("NO MONEY FOR THIS");
            return false;
        }

    }
}
