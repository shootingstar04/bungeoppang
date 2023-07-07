using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodData : MonoBehaviour
{
    public static FoodData instance;

    public int[,] FoodMenu = new int[2, 6];

    void Awake()
    {
        if (FoodData.instance == null)
            FoodData.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        int z = 0;
        for (int i = 0; i < FoodMenu.GetLength(0); i++)
            for (int j = 0; j < FoodMenu.GetLength(1); j++)
            {
                FoodMenu[i, j] = z;
                ++z;
            }
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
        if (FoodMenu[MenuCode, 1] >= FoodMenu[MenuCode, 2])
            MenuLevelUp(MenuCode);

        PlayerPrefs.SetInt("FoodLevel", FoodMenu[MenuCode, 0]);
        PlayerPrefs.SetInt("FoodCurExp", FoodMenu[MenuCode, 1]);
        PlayerPrefs.SetInt("FoodMaxExp", FoodMenu[MenuCode, 2]);
    }

    private void MenuLevelUp(int MenuCode)
    {
        FoodMenu[MenuCode, 1] = 0;

        if (FoodMenu[MenuCode, 2] < 5)
            ++FoodMenu[MenuCode, 2];

        ++FoodMenu[MenuCode, 0];
    }
}
