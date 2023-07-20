using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TestNewprefab : MonoBehaviour
{
    private ScrollRect scrollRect;
    public GameObject prefab;
    public List<RectTransform> rectTransforms = new List<RectTransform>();
    int num = 0;
    int y = 0;
    // Update is called once per frame
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (num == 0)
            {
                Vector2 position = new Vector2(-120, y - 440);
                var prefabObject = Instantiate(prefab, scrollRect.content).GetComponent<RectTransform>();
                prefabObject.anchoredPosition = position;
                num++;
                y = y + 80;
            }
            else
            {
                Vector2 position = new Vector2(120, y - 440);
                var prefabObject = Instantiate(prefab, scrollRect.content).GetComponent<RectTransform>();
                prefabObject.anchoredPosition = position;
                num--;
                y = y + 80;
            }
        }
    }

}