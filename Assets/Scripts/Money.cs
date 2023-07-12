using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static Money instance;               // �̱��� ���� ����

    [SerializeField] Text MoneyText;            // ��ȭ�� ��� �ؽ�Ʈ

    public int money = 0;                       // ���� ���� ��ȭ��

    void Awake()                                // ���� ���� �� ȣ��
    {
        if(Money.instance == null)          
            Money.instance = this;
    }

    void Start()                                // ���� ���� �� ȣ��
    {
        if (!PlayerPrefs.HasKey("Money"))       // ���� Money�� �����Ͱ� ���ٸ�
        {
            PlayerPrefs.SetInt("Money", 500);   // Money�� ������ ����
            Load();                             // ���� ������ �ε�
        }
        else                                    // �ƴ� ���
        {
            Load();                             // ���� ������ �ε�
        }
    }

    void Update()                               // ���� ������ �� ȣ��
    {
        MoneyText.text = money.ToString();      // ��ȭ�� ���
    }

    public void UseMoney(int useMoney)          // ��ȭ ��� �Լ�
    {
        money -= useMoney;                      // ��ȭ�� ����
        Save();                                 // ���� ������ ����
    }

    public void AcquireMoney(int AcqMoney)      // ��ȭ ȹ�� �Լ�
    {
        money += AcqMoney;                      // ��ȭ�� ����
        Save();                                 // ���� ������ ����
    }

    void Load()                                 // ���� ������ �ε� �Լ�
    {
        money = PlayerPrefs.GetInt("Money");    // ��ȭ���� Money ������ ����
    }

    void Save()                                 // ���� ������ ���̺� �Լ�
    {
        PlayerPrefs.SetInt("Money", money);     // Money�� ���� ��ȭ�� ����
    }
}
