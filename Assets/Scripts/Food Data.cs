using LitJson;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodData : MonoBehaviour
{
    public static FoodData instance;

    public TextAsset Data;
    public JsonData MenuData;
    public Sprite[] sprites;

    void Awake()
    {
        if (FoodData.instance == null)
            FoodData.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        MenuData = JsonMapper.ToObject(Data.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        
    }

    public void Save(int MenuCode)
    {
        
    }

    private void MenuLevelUp(int MenuCode)
    {
        
    }
}
