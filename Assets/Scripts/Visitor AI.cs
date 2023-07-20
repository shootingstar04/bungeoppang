using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorAI : MonoBehaviour
{
    public static VisitorAI instance;

    public Transform DestinationPoint;
    public Transform SpawnPoint;

    public GameObject SpeechBubble;

    public float Speed = 1.0f;
    public bool Bought = false;
    public bool Select = false;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Select == false && Bought == false && transform.position == DestinationPoint.position)
        {
            SpeechBubble.SetActive(true);
            SelectMenu.instance.Select();
            Select = true;
        }
        else if (Bought == false && transform.position != DestinationPoint.position)
            transform.position = Vector2.MoveTowards(transform.position, DestinationPoint.position, Speed * Time.deltaTime);
        else if (Bought == true && transform.position != SpawnPoint.position)
            transform.position = Vector2.MoveTowards(transform.position, SpawnPoint.position, Speed * Time.deltaTime);
        else if (Bought == true && transform.position == SpawnPoint.position)
            Destroy(gameObject);
    }

    public void SalesCompleted()
    {
        Bought = true;
    }
}
