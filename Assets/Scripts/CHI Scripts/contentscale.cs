using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contentscale : MonoBehaviour
{
    public GameObject content;
    int num = 0;
    int y = 0;

    void Update()
    {
        RectTransform rectTransform = content.GetComponent<RectTransform>();
        if (rectTransform == null)
        {
            Debug.LogError("RectTransform component not found in the content GameObject.");
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (num == 0)
            {
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, y);
                num++;
                y = y - 146;
            }
            else
            {
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, y);
                num--;
                y = y - 146;
            }
        }
    }
}
