using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static Level instance;

    [SerializeField] Text levetText;
    [SerializeField] Image expImage;

    public int level = 1;
    public int CurExp = 0;
    public int MaxExp = 100;

    void Awake()
    {
        if (Level.instance == null)
            Level.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("CurExp"))
        {
            PlayerPrefs.SetInt("Level", 1);
            PlayerPrefs.SetInt("CurExp", 0);
            PlayerPrefs.SetInt("MaxExp", 100);
            Load();
        }
        else
        {
            Load();
        };
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurExp);
        
        if (CurExp != 0)
            expImage.fillAmount = (CurExp / MaxExp);
        else if (CurExp == 0)
            expImage.fillAmount = 0;
        
        levetText.text = level.ToString();
        

        if (CurExp >= MaxExp)
            LevelUp();
    }

    public void AcquireExp()
    {

        Save();
    }

    private void LevelUp()
    {
        CurExp -= MaxExp;
        ++level;
        ActivityPower.instance.RecoveryAP();
        Save();
    }

    void Load()
    {
        level = PlayerPrefs.GetInt("Level");
        CurExp = PlayerPrefs.GetInt("CurExp");
        MaxExp = PlayerPrefs.GetInt("MaxExp");
}

    void Save()
    {
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetInt("CurExp", CurExp);
        PlayerPrefs.SetInt("MaxExp", MaxExp);
    }
}
