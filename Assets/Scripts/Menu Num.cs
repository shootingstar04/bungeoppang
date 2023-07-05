using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNum : MonoBehaviour
{
    public static MenuNum instance;

    public int menuCode = 0;
    public int UseAP = 0;
    public int UseMoney = 0;

    void Awake()
    {
        if (MenuNum.instance == null)
            MenuNum.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuUpdate()
    {
        MenuSetting.instance.MenuCode = menuCode;
        MenuSetting.instance.SelectMenu();

        CookingSystem.instance.MenuCode = menuCode;
        CookingSystem.instance.useAP = UseAP;
        CookingSystem.instance.useMoney = UseMoney;
    }
}
