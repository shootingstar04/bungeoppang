using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenu : MonoBehaviour
{
    public static SelectMenu instance;

    public Sprite QuestionMark;

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

        num = Random.Range(0, CompletionFood.instance.FoodMax);

        if (CompletionFood.instance.FoodKind > 0)
        {
            for (; ; )
            {
                if (CompletionFood.instance.FoodCode[num] != -1)
                {
                    gameObject.SetActive(true);
                    gameObject.GetComponent<SpriteRenderer>().sprite = FoodData.instance.sprites[CompletionFood.instance.FoodCode[num]];
                    SellSystem.instance.num = num;
                    break;
                }
                else
                {
                    num = Random.Range(0, CompletionFood.instance.FoodMax);
                }
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = QuestionMark;
        }
    }
}
