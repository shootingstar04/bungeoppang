using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SellSystem : MonoBehaviour , IPointerUpHandler, IPointerDownHandler
{
    public static SellSystem instance;

    public int num;
    public bool Worry = false;

    void Awake()
    {
        if (SellSystem.instance == null)
            SellSystem.instance = this;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Sell(int num)
    {
        CompletionFood.instance.FoodAmount[num] -= 1;

        int money = int.Parse(FoodData.instance.MenuData[CompletionFood.instance.FoodCode[num]]["AcquireMoney"].ToString());
        Money.instance.AcquireMoney(money);

        int exp = int.Parse(FoodData.instance.MenuData[CompletionFood.instance.FoodCode[num]]["AcquireExp"].ToString());
        Level.instance.AcquireExp(exp);
        
        transform.parent.GetComponent<VisitorAI>().Bought = true;
        Destroy(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (transform.GetComponentInChildren<SelectMenu>(true).NoFood == false)
            Sell(num);
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
