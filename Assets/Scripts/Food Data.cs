using LitJson;
using System.IO;
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
        Load();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Load()
    {
        
    }

    public void Save(int MenuCode)
    {
        
    }

    private void MenuLevelUp(int MenuCode)
    {
        
    }
}
