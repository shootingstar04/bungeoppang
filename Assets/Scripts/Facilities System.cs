using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacilitiesSystem : MonoBehaviour
{
    public static FacilitiesSystem instance;

    [SerializeField] GameObject NoMoneyWindow;
    public GameObject[] Object;

    public int useMoney = 0;
    public int FacilitiesCode;

    void Awake()
    {
        if (FacilitiesSystem.instance == null)
            FacilitiesSystem.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        if (useMoney <= Money.instance.money)
        {
            Money.instance.money -= useMoney;
            GetComponent<Button>().interactable = false;
            
            switch(FacilitiesCode)
            {
                case 1 :
                    VisitorData.instance.SeatMax += 2;
                    Object[0].SetActive(true);
                    Object[1].SetActive(true);
                    Object[2].SetActive(true);
                    break;
                case 2 :
                    CompletionFood.instance.FoodMax += 2;
                    Object[0].SetActive(true);
                    Object[1].SetActive(true);
                    break;
                case 3 :
                    Object[0].SetActive(true);
                    break;
            }
            
        }
        else if (useMoney > Money.instance.money)
        {
            NoMoneyWindow.SetActive(true);
        }
    }
}
