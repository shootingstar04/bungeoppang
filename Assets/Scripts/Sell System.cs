using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SellSystem : MonoBehaviour , IPointerUpHandler, IPointerDownHandler
{
    public GameObject Visitor;
    
    void Start()
    {
        Visitor = transform.parent.gameObject;
    }

    void Update()
    {
        
    }

    public void Sell()
    {
        CompletionFood.instance.FoodAmount[0] -= 1;
        Money.instance.AcquireMoney(500);
        Level.instance.AcquireExp(15);
        Visitor.GetComponent(typeof(VisitorAI));
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Sell();
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
