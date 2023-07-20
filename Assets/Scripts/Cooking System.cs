using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingSystem : MonoBehaviour
{
    public static CookingSystem instance;

    [SerializeField] GameObject NoAPWindow;
    [SerializeField] GameObject NoMoneyWindow;
    [SerializeField] GameObject NoSiteWindow;

    public int MenuCode = 0;

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
        int useAP = int.Parse(FoodData.instance.MenuData[MenuCode]["UseAP"].ToString());
        int useMoney = int.Parse(FoodData.instance.MenuData[MenuCode]["UseMoney"].ToString());

        if (CompletionFood.instance.FoodKind == CompletionFood.instance.FoodMax)
        {
            NoSiteWindow.SetActive(true);
        }
        else if (useAP <= ActivityPower.instance.CurAP  && useMoney <= Money.instance.money)
        {
            int num = 0;

            if (CompletionFood.instance.OverlapFood(MenuCode) != -1)
                num = CompletionFood.instance.OverlapFood(MenuCode);
                
            else if (CompletionFood.instance.ThereFood() != -1)
            {
                num = CompletionFood.instance.ThereFood();
                CompletionFood.instance.FoodExist[num] = true;
                CompletionFood.instance.FoodCode[num] = MenuCode;
                ++CompletionFood.instance.FoodKind;
                CompletionFood.instance.DisplayingFood(num, MenuCode);
            }

            CompletionFood.instance.FoodAmount[num] += 2;
            
            ActivityPower.instance.UseAP(useAP);
            Money.instance.UseMoney(useMoney);

            int exp = int.Parse(FoodData.instance.MenuData[MenuCode]["CurExp"].ToString());
            ++exp;
            FoodData.instance.MenuData[MenuCode]["CurExp"] = exp;

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
