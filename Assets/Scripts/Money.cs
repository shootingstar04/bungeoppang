using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static Money instance;

    [SerializeField] Text MoneyText;

    public int money = 0;

    void Awake()
    {
        if(Money.instance == null)
            Money.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("CurAP"))
        {
            PlayerPrefs.SetInt("money", 500);
            Load();
        }
        else
        {
            Load();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = money.ToString();
        Save();
    }

    void Load()
    {
        money = PlayerPrefs.GetInt("Mevel");
    }

    void Save()
    {
        PlayerPrefs.SetInt("Money", money);
    }
}
