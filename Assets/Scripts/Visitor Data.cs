using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorData : MonoBehaviour
{
    public static VisitorData instance;

    public int[] Seat;
    public int SeatMax;
    public int VisitorNum = 0;

    private float CurTime;

    public GameObject Visitor;

    public Transform SpawnPoint;
    public Transform Target;

    void Awake()                                
    {
        if (VisitorData.instance == null)
            VisitorData.instance = this;
    }

    void Start()
    {
        SeatMax = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (VisitorNum < SeatMax)
        {
            CurTime += Time.deltaTime;
        }

        if (CurTime > 5)
        {
            GameObject visitor = Instantiate(Visitor);

            visitor.transform.position = new Vector2(SpawnPoint.position.x, SpawnPoint.position.y);

            CurTime = 0;
            ++VisitorNum;
        }
    }
}
