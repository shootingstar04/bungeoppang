using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSort : MonoBehaviour
{
    public GameObject[] Menu;

    public int[] MenuType = {0, 1};
    private int MenuMax = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AllSort()
    {
        for (int i = 0; i < MenuMax; ++i)
            Menu[i].SetActive(true);
    }

    public void BSort()
    {
        for (int i = 0; i < MenuMax; ++i)
            Menu[i].SetActive(true);

        for (int i = 0; i < MenuMax; ++i)
        {
            if (MenuType[i] != 0)
                Menu[i].SetActive(false);
        }
    }

    public void TSort()
    {
        for (int i = 0; i < MenuMax; ++i)
            Menu[i].SetActive(true);

        for (int i = 0; i < MenuMax; ++i)
        {
            if (MenuType[i] != 1)
                Menu[i].SetActive(false);
        }
    }

    public void WSort()
    {
        for (int i = 0; i < MenuMax; ++i)
            Menu[i].SetActive(true);

        for (int i = 0; i < MenuMax; ++i)
        {
            if (MenuType[i] != 2)
                Menu[i].SetActive(false);
        }
    }

    public void DSort()
    {
        for (int i = 0; i < MenuMax; ++i)
            Menu[i].SetActive(true);

        for (int i = 0; i < MenuMax; ++i)
        {
            if (MenuType[i] != 3)
                Menu[i].SetActive(false);
        }
    }
}
