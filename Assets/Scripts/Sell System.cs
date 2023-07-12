using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sell()
    {
        CompletionFood.instance.FoodAmount[0] -= 1;
        Money.instance.AcquireMoney(500);
        Level.instance.AcquireExp(15);
    }    
}
