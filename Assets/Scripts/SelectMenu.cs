using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenu : MonoBehaviour
{
    public static SelectMenu instance;

    void Awake()
    {
        if (SelectMenu.instance == null)
            SelectMenu.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select()
    {
        int num = 0;

        for (; ; )
        {
            num = Random.Range(0, CompletionFood.instance.FoodMax);

            if (CompletionFood.instance.FoodCode[num] != -1)
                break;
            else
                break;
        }

        gameObject.SetActive(true);
        gameObject.GetComponent<SpriteRenderer>().sprite = FoodData.instance.sprites[CompletionFood.instance.FoodCode[num]];
    }
}
