using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSetting : MonoBehaviour
{
    public static MenuSetting instance;

    public Sprite[] sprites;

    [SerializeField] Image MenuImage;
    [SerializeField] Text MenuLevel;
    [SerializeField] Text MenuExp;
    [SerializeField] Text NeedMoney;
    [SerializeField] Text NeedAP;
    [SerializeField] Text MenuNum;

    public int MenuCode = 0;

    void Awake()
    {
        if (MenuSetting.instance == null)
            MenuSetting.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMenu()
    {
        MenuImage.sprite = sprites[MenuCode];
        MenuLevel.text = FoodData.instance.FoodMenu[MenuCode, 0].ToString();
        MenuExp.text = FoodData.instance.FoodMenu[MenuCode, 1].ToString() 
             + "/" + FoodData.instance.FoodMenu[MenuCode, 2].ToString();
        NeedMoney.text = FoodData.instance.FoodMenu[MenuCode, 3].ToString();
        NeedAP.text = FoodData.instance.FoodMenu[MenuCode, 4].ToString();
        MenuNum.text = FoodData.instance.FoodMenu[MenuCode, 5].ToString();
    }
}
