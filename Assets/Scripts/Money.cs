using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static Money instance;               // 싱글톤 패턴 구현

    [SerializeField] Text MoneyText;            // 재화량 출력 텍스트

    public int money = 0;                       // 현재 보유 재화량

    void Awake()                                // 게임 시작 전 호출
    {
        if(Money.instance == null)          
            Money.instance = this;
    }

    void Start()                                // 게임 시작 후 호출
    {
        if (!PlayerPrefs.HasKey("Money"))       // 만약 Money에 데이터가 없다면
        {
            PlayerPrefs.SetInt("Money", 500);   // Money에 데이터 저장
            Load();                             // 게임 데이터 로드
        }
        else                                    // 아닐 경우
        {
            Load();                             // 게임 데이터 로드
        }
    }

    void Update()                               // 게임 프레임 당 호출
    {
        MoneyText.text = money.ToString();      // 재화량 출력
    }

    public void UseMoney(int useMoney)          // 재화 사용 함수
    {
        money -= useMoney;                      // 재화량 감소
        Save();                                 // 게임 데이터 저장
    }

    public void AcquireMoney(int AcqMoney)      // 재화 획득 함수
    {
        money += AcqMoney;                      // 재화량 증가
        Save();                                 // 게임 데이터 저장
    }

    void Load()                                 // 게임 데이터 로드 함수
    {
        money = PlayerPrefs.GetInt("Money");    // 재화량에 Money 데이터 삽입
    }

    void Save()                                 // 게임 데이터 세이브 함수
    {
        PlayerPrefs.SetInt("Money", money);     // Money에 보유 재화량 저장
    }
}
