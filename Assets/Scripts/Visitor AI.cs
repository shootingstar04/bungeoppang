using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorAI : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

    //  Target.transform.position = new Vector2(0, VisitorData.instance.VisitorNum - 2.3f);
    }
}
