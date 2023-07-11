using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletionFood : MonoBehaviour
{
    public static CompletionFood instance;

    public bool[] FoodExist;
    public int[]  FoodCode;
    public int[] FoodAmount;

    public int FoodMax = 2;

    void Awake()
    {
        if (CompletionFood.instance == null)
            CompletionFood.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        FoodExist = new bool[8];
        FoodCode = new int[8];
        FoodAmount = new int[8];

        for (int i = 0; i < FoodMax; ++i)
        {
            FoodExist[i] = false;
            FoodCode[i] = -1;
            FoodAmount[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < FoodMax; ++i)
        {
            if (FoodCode[i] != -1 && FoodAmount[i] <= 0)
            {
                FoodExist[i] = false;
                FoodCode[i] = -1;
            }
        }
    }

    public int ThereFood()
    {
        for (int i = 0; i < FoodMax; ++i)
        {
            if (FoodExist[i] == false)
                return i;
        }

        return -1;
    }

    public int OverlapFood()
    {
        for (int i = 0; i < FoodMax; ++i)
        {
            if (CookingSystem.instance.MenuCode == FoodCode[i])
                return i;
        }

        return -1;
    }
}
