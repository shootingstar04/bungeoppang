using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingList : MonoBehaviour
{
    public GameObject List;

    // Start is called before the first frame update
    void Start()
    {
        List.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        if (List.activeSelf == false)
            List.SetActive(true);
        else if (List.activeSelf == true)
            List.SetActive(false);
    }
}
