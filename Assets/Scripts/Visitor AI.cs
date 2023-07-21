using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorAI : MonoBehaviour
{
    public static VisitorAI instance;

    public Transform DestinationPoint;
    public Transform SpawnPoint;

    public GameObject SpeechBubble;

    int n = 0;

    public float Speed = 1.0f;
    public bool Bought = false;
    public bool Select = false;
    public bool Choice = false;
    public bool Eat    = false;

    private float DeltaTime = 0;


    void Start()
    {
        n = VisitorData.instance.ChoiceSeat();
    }

    
    void Update()
    {
        if (Select == false && Bought == false && transform.position == DestinationPoint.position)
        {
            SpeechBubble.SetActive(true);
            SelectMenu.instance.Select();
            Select = true;
        }
        else if (Select == true && Bought == false && transform.GetComponentInChildren<SellSystem>(true).Worry == true && CompletionFood.instance.FoodKind != 0)
            SelectMenu.instance.Select();
        else if (Bought == false && transform.position != DestinationPoint.position)
            transform.position = Vector2.MoveTowards(transform.position, DestinationPoint.position, Speed * Time.deltaTime);
        else if (Bought == true && Eat == false && Choice == false)
        {
            Choice = true;
            VisitorData.instance.Seat[n] = true;
        }
        else if (Bought == true && Eat == false && Choice == true)
            transform.position = Vector2.MoveTowards(transform.position, VisitorData.instance.Chair[n].transform.position, Speed * Time.deltaTime);
        else if (Bought == true && Eat == true && transform.position != SpawnPoint.position)
            transform.position = Vector2.MoveTowards(transform.position, SpawnPoint.position, Speed * Time.deltaTime);
        else if (Bought == true && Eat == true && transform.position == SpawnPoint.position)
        {
            VisitorData.instance.VisitorNum -= 1;
            Destroy(gameObject);
        }
    }

    public void SalesCompleted()
    {
        Bought = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chair")
        {
            Eat = true;
            VisitorData.instance.Seat[n] = false;
        }
    }
}
