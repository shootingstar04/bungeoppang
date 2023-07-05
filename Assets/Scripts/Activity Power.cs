using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityPower : MonoBehaviour
{
    public static ActivityPower instance;

    [SerializeField] Text APText;
    [SerializeField] Text TimerText;
    [SerializeField] Slider APBar;

    public int CurAP = 0;          // 보유 행동력
    public int MaxAP = 15;             // 최대 행동력

    private int restoreDuration = 30;   // 행동력 회복 간격(s)
    private DateTime nextAPTime;
    private DateTime lastAPTime;
    private bool isRestoring = false;   // 회복 여부

    void Awake()
    {
        if (ActivityPower.instance == null)
            ActivityPower.instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CurAP", MaxAP);
        Load();
        StartCoroutine(RestoreAP());
    }

    void Update()
    {
        if (APBar.value <= 0)
            APBar.transform.Find("Fill Area").gameObject.SetActive(false);
        else
            APBar.transform.Find("Fill Area").gameObject.SetActive(true);
    }

    public void UseAP()
    {
        if (CurAP >= 1)
        {
            UpdateAP();

            if (isRestoring == false)
            {
                if (CurAP + 1 == MaxAP)
                {
                    nextAPTime = AddDuration(DateTime.Now, restoreDuration);
                }

                StartCoroutine(RestoreAP());
            }
        }
        else
        {
            Debug.Log("에너지 부족");
        }
    }

    private IEnumerator RestoreAP()
    {
        UpdateAPTimer();
        isRestoring = true;

        while (CurAP < MaxAP)
        {
            DateTime CurrentDateTime = DateTime.Now;
            DateTime NextDateTime = nextAPTime;
            bool isAPAdding = false;

            while (CurrentDateTime > NextDateTime)
            {
                if (CurAP < MaxAP)
                {
                    isAPAdding = true;
                    CurAP++;
                    UpdateAP();
                    DateTime timeToAdd = lastAPTime > NextDateTime ? lastAPTime : NextDateTime;
                    NextDateTime = AddDuration(timeToAdd, restoreDuration);
                }
                else
                {
                    break;
                }
            }

            if (isAPAdding == true)
            {
                lastAPTime = DateTime.Now;
                nextAPTime = NextDateTime;
            }

            UpdateAPTimer();
            UpdateAP();
            Save();
            yield return null;
        }

        isRestoring = false;
    }

    private DateTime AddDuration(DateTime datetime, int duration)
    {
        return datetime.AddSeconds(duration);
    }

    private void UpdateAPTimer()
    {
        if (CurAP >= MaxAP)
        {
            TimerText.text = "MAX";
            return;
        }

        TimeSpan time = nextAPTime - DateTime.Now;
        string timeValue = String.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
        TimerText.text = timeValue;
    }

    private void UpdateAP()
    {
        APText.text = CurAP.ToString() + "/" + MaxAP.ToString();

        APBar.maxValue = MaxAP;
        APBar.value = CurAP;
    }

    private DateTime StringToDate(string datetime)
    {
        if (string.IsNullOrEmpty(datetime))
        {
            return DateTime.Now;
        }
        else
        {
            return DateTime.Parse(datetime);
        }
    }

    private void Load()
    {
        CurAP = PlayerPrefs.GetInt("CurrentAP");
        nextAPTime = StringToDate(PlayerPrefs.GetString("nextAPTime"));
        lastAPTime = StringToDate(PlayerPrefs.GetString("lastAPTime"));
        APText.text = CurAP.ToString() + "/" + MaxAP.ToString();
    }

    private void Save()
    {
        PlayerPrefs.SetInt("CurrentAP", CurAP);
        PlayerPrefs.SetString("nextAPTime", nextAPTime.ToString());
        PlayerPrefs.SetString("lastAPTime", lastAPTime.ToString());
    }
}