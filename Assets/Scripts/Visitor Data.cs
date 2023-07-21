using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorData : MonoBehaviour
{
    public static VisitorData instance;

    public bool[] Seat;
    public int SeatMax;
    public int VisitorNum = 0;

    private float CurTime;

    public GameObject Visitor;

    public Transform[] SpawnPoint;
    public Transform DestroyPoint;

    void Awake()                                
    {
        if (VisitorData.instance == null)
            VisitorData.instance = this;
    }

    void Start()
    {
        SeatMax = 4;
        Seat = new bool[8];
        for (int i = 0; i < 8; ++i)
            Seat[i] = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (VisitorNum < SeatMax)
        {
            CurTime += Time.deltaTime;
        }

        if (CurTime > 15)
        {
            GameObject visitor = Instantiate(Visitor);
            
            int n = Random.RandomRange(0, 2);

            visitor.transform.position = new Vector2(SpawnPoint[n].position.x, SpawnPoint[n].position.y);

            CurTime = 0;
            ++VisitorNum;
        }
    }
}
