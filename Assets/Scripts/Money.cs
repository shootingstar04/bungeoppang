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
        PlayerPrefs.SetInt("money", 500);
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = money.ToString();
    }
}
