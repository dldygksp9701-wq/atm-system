using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyDot : MonoBehaviour
{
    public TextMeshProUGUI moneyInputAmount;
    public TextMeshProUGUI curMoneyAmount;
    void Start()
    {
        //OnFormatMoney(moneyInputAmount.text);
    }

    
    void Update()
    {
        
    }

    //string OnFormatMoney(string text)
    //{
    //    int moneyInput = int.Parse(moneyInputAmount.text);
    //    int curMoney = int.Parse(curMoneyAmount.text);
    //    moneyInputAmount.text = string.Format("{0:#,###}", moneyInput);
    //    curMoneyAmount.text = string.Format("{0:#,###}", curMoney);
    //    return text;
    //}
}
