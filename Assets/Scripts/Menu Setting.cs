using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSetting : MonoBehaviour
{
    public static MenuSetting instance;

    public Sprite[] sprites;

    [SerializeField] Image MenuImage;
    [SerializeField] Text MenuLevel;
    [SerializeField] Text MenuExp;
    [SerializeField] Text NeedMoney;
    [SerializeField] Text NeedAP;
    [SerializeField] Text MenuNum;

    public int MenuCode = 0;

    void Awake()
    {
        if (MenuSetting.instance == null)
            MenuSetting.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMenu()
    {
        switch (MenuCode)
        {
            case 1:
                MenuImage.sprite = sprites[MenuCode - 1];
                MenuLevel.text = "1";
                MenuExp.text = "0" + "/" + "2";
                NeedMoney.text = "000";
                NeedAP.text = "1";
                MenuNum.text = "1";
                break;
            case 2 :
                MenuImage.sprite = sprites[MenuCode - 1];
                MenuLevel.text = "1";
                MenuExp.text = "0" + "/" + "2";
                NeedMoney.text = "100";
                NeedAP.text = "2";
                MenuNum.text = "1";
                break;
            default :
                break;
        }
    }
}
