using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodData : MonoBehaviour
{
    public static FoodData instance;

    public int[]    MenuCode;
    public string[] MenuName;
    public string[] MenuType;
    public int[]    ReleaseLevel;
    public string[] ReleaseConditions;
    public int[]    MenuLevel;
    public int[]    MenuCurExp;
    public int[]    MenuMaxExp;
    public int[]    UseMoney;
    public int[]    UseAP;
    public int[]    AcquireMoney;
    public int[]    AcquireExp;
    public string[] ExplanationMenu;

    public int[,] FoodMenu = new int[2, 6];

    void Awake()
    {
        if (FoodData.instance == null)
            FoodData.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Load();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Load()
    {
        
    }

    public void Save(int MenuCode)
    {
        
    }

    private void MenuLevelUp(int MenuCode)
    {
        FoodMenu[MenuCode, 1] = 0;

        if (FoodMenu[MenuCode, 2] < 5)
            ++FoodMenu[MenuCode, 2];

        ++FoodMenu[MenuCode, 0];
    }
}
