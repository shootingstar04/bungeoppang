using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSetting : MonoBehaviour
{
    public static MenuSetting instance;

    [SerializeField] Text MenuName;
    [SerializeField] Image MenuImage;
    [SerializeField] Text MenuLevel;
    [SerializeField] Text MenuExp;
    [SerializeField] Text UseMoney;
    [SerializeField] Text UseAP;
    [SerializeField] Text MenuNum;
    [SerializeField] Text MenuDescription;

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
        MenuName.text = FoodData.instance.MenuData[MenuCode]["MenuName"].ToString();
        MenuImage.sprite = FoodData.instance.sprites[MenuCode];
        MenuLevel.text = FoodData.instance.MenuData[MenuCode]["MenuLevel"].ToString();
        MenuExp.text = FoodData.instance.MenuData[MenuCode]["CurExp"].ToString() 
             + "/" + FoodData.instance.MenuData[MenuCode]["MaxExp"].ToString();
        UseMoney.text = FoodData.instance.MenuData[MenuCode]["UseMoney"].ToString();
        UseAP.text = FoodData.instance.MenuData[MenuCode]["UseAP"].ToString();
        MenuNum.text = 2.ToString();
        MenuDescription.text = FoodData.instance.MenuData[MenuCode]["MenuDescription"].ToString();
    }
}
