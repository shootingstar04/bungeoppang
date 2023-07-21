using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class likabilitySystem : MonoBehaviour
{
    public static likabilitySystem instance;
    [SerializeField] Text likabilityText;
    public int likability = 0;

    public void Awake()
    {
        if (likabilitySystem.instance == null)
            likabilitySystem.instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        likabilityText.text = likability.ToString();
    }

    public void AcquireLikability(int AcqLikability)
    {
        likability += AcqLikability;
        if (likability >= 100)
        {
            likability = 100;
        }
    }
}