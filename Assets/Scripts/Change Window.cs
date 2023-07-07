using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeWindow : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] GameObject CharacterList;
    [SerializeField] GameObject StoryList;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        CharacterList.SetActive(false);
        StoryList.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
