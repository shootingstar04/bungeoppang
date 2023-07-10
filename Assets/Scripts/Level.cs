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
    public float curexp = 0;
    public float maxexp = 100;

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
        expImage.fillAmount = (curexp / maxexp);

        if (curexp >= maxexp)
            LevelUp();
    }

    private void LevelUp()
    {
        curexp -= maxexp;
        ++level;
        levetText.text = level.ToString();
        ++ActivityPower.instance.MaxAP;
        ActivityPower.instance.CurAP = ActivityPower.instance.MaxAP;
    }
}
