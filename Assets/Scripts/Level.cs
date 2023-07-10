using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static Level instance;

    [SerializeField] Text levetText;
    [SerializeField] Image expImage;

    public int level;
    public float CurExp = 0;
    public float MaxExp = 100;

    void Awake()
    {
        if (Level.instance == null)
            Level.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        expImage.fillAmount = (CurExp / MaxExp);

        if (CurExp >= MaxExp)
            LevelUp();
    }

    private void LevelUp()
    {
        CurExp -= MaxExp;
        ++level;
        levetText.text = level.ToString();
        ++ActivityPower.instance.MaxAP;
        ActivityPower.instance.CurAP = ActivityPower.instance.MaxAP;
    }

    private void Load()
    {
        level = PlayerPrefs.GetInt("level");
        CurExp = PlayerPrefs.GetFloat("CurExp");
        MaxExp = PlayerPrefs.GetFloat("MaxExp");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetFloat("CurExp", CurExp);
        PlayerPrefs.SetFloat("MaxExp", MaxExp);
    }
}
