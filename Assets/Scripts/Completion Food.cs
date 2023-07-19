using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompletionFood : MonoBehaviour
{
    public static CompletionFood instance;

    public bool[] FoodExist;
    public int[]  FoodCode;
    public int[]  FoodAmount;

    public GameObject[] DisplayStand1;
    public GameObject[] DisplayStand2;

    public int FoodMax = 2;

    void Awake()
    {
        if (CompletionFood.instance == null)
            CompletionFood.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        FoodExist = new bool[6];
        FoodCode = new int[6];
        FoodAmount = new int[6];

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
                DisplayStand1[i].SetActive(false);
                DisplayStand2[i].SetActive(false);
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

    public void DisplayingFood(int num, int MenuCode)
    {
        DisplayStand1[num].SetActive(true);
        DisplayStand1[num].GetComponent<Image>().sprite = FoodData.instance.sprites[MenuCode];
        DisplayStand2[num].SetActive(true);
        DisplayStand2[num].GetComponent<SpriteRenderer>().sprite = FoodData.instance.sprites[MenuCode];
    }
}
