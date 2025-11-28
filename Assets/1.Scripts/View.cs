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
    public GameObject ui_sign;
    public TMP_InputField signInId;
    public TMP_InputField signInPassword;
    public TMP_InputField signName;
    public TMP_InputField signCash;
    public TMP_InputField signBalance;
    public GameObject Send;
    public GameObject signError;//회원가입할때 누락시 생기는 알림창

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

    public void OnSendBackButton()
    {

        Send.SetActive(false);
        depositAndWithdrawal.SetActive(true);

    }
    public void OnPopBank()
    {
        ui_Login.SetActive(false);
        popBank.SetActive(true);

    }

    public void UiSign()
    {
        ui_sign.SetActive(true);
    }
    public void UiSignClose()
    {
        ui_sign.SetActive(false);
    }

    public void OnSign()
    {
        
        
            GameManager.instance.SaveJson();
        
       

    }

    public void OnSignCancle()
    {
        ui_sign.SetActive(false);
    }

    public void OnErrorClose()
    {
        signError.SetActive(false );
    }

    public void OnSend()
    {
        Send.SetActive (true);
        depositAndWithdrawal.SetActive(false);
    }
}
