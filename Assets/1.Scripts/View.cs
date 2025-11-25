using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{

    public GameObject deposit_Btn;
    public GameObject withdrawal_Btn;
    public GameObject depositAndWithdrawal;
    public GameObject popBank;
    public GameObject ui_Login;



    void Start()
    {
        
    }


    void Update()
    {

    }
    public void OnDespositButton()
    {
        depositAndWithdrawal.SetActive(false);
        deposit_Btn.SetActive(true);

    }

    public void OnWithdrawalButton()
    {
        depositAndWithdrawal.SetActive(false);
        withdrawal_Btn.SetActive(true);

    }
    public void OnDespositBackButton()
    {

        deposit_Btn.SetActive(false);
        depositAndWithdrawal.SetActive(true);



    }
    public void OnWithdrawalBackButton()
    {

        withdrawal_Btn.SetActive(false);
        depositAndWithdrawal.SetActive(true);

    }
    public void OnPopBank()
    {
        ui_Login.SetActive(false);
        popBank.SetActive(true);

    }
}
