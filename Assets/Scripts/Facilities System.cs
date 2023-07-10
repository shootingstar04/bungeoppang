using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacilitiesSystem : MonoBehaviour
{
    public static FacilitiesSystem instance;

    [SerializeField] GameObject NoMoneyWindow;

    public int useMoney = 0;

    void Awake()
    {
        if (FacilitiesSystem.instance == null)
            FacilitiesSystem.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        if (useMoney <= Money.instance.money)
        {
            Money.instance.money -= useMoney;
            GetComponent<Button>().interactable = false;
        }
        else if (useMoney > Money.instance.money)
        {
            NoMoneyWindow.SetActive(true);
        }
    }
}
