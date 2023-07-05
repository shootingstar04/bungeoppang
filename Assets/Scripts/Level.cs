using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] Text levetText;
    [SerializeField] Image expImage;

    private int level;
    private float curexp = 0;
    private float maxexp = 100;

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
    }
}
