using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SellSystem : MonoBehaviour , IPointerUpHandler, IPointerDownHandler
{
    public static SellSystem instance;

    public int num;

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

        int money = int.Parse(FoodData.instance.MenuData[num]["AcquireMoney"].ToString());
        Money.instance.AcquireMoney(money);

        int exp = int.Parse(FoodData.instance.MenuData[num]["AcquireExp"].ToString());
        Level.instance.AcquireExp(exp);
        
        transform.parent.GetComponent<VisitorAI>().Bought = true;
        Destroy(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Sell(num);
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
