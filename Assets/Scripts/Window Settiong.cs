using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSettiong : MonoBehaviour
{
    public GameObject   window;
    public GameObject[] WindowList;

    // Start is called before the first frame update
    void Start()
    {
        window.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        if (window.activeSelf == false)
            window.SetActive(true);
        else if (window.activeSelf == true)
            window.SetActive(false);

        for (int i = 0; i < WindowList.Length; i++)
            WindowList[i].SetActive(false);
    }
}
