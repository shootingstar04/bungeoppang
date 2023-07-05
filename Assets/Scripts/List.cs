using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public GameObject list;

    // Start is called before the first frame update
    void Start()
    {
        list.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        if (list.activeSelf == false)
            list.SetActive(true);
        else if (list.activeSelf == true)
            list.SetActive(false);
    }
}
