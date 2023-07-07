using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingSystem : MonoBehaviour
{
    public static CookingSystem instance;

    [SerializeField] GameObject NoAPWindow;
    [SerializeField] GameObject NoMoneyWindow;

    public int MenuCode = 0;
    public int useAP = 0;
    public int useMoney = 0;

    void Awake()
    {
        if (CookingSystem.instance == null)
            CookingSystem.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Cooking()
    {
        if (useAP <= ActivityPower.instance.CurAP  && useMoney <= Money.instance.money)
        {
            ActivityPower.instance.CurAP -= useAP;
            ActivityPower.instance.UseAP();
            Money.instance.money -= useMoney;

            ++FoodData.instance.FoodMenu[MenuCode, 1];
            FoodData.instance.Save(MenuCode);
        }
        else if (useAP > ActivityPower.instance.CurAP)
        {
            NoAPWindow.SetActive(true);
        }
        else if (useMoney > Money.instance.money)
        {
            NoMoneyWindow.SetActive(true);
        }
    }
}
