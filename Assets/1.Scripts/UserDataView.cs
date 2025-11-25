using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserDataView : MonoBehaviour
{
    public TextMeshProUGUI textName;
    public TextMeshProUGUI textBarBallance;
    public TextMeshProUGUI textCash;
    public TMP_InputField inputField_1;
    public TMP_InputField inputField_2;
    public Button tenThousandButton;
    public GameObject lack;
    public TMP_InputField idInput;
    public TMP_InputField passwordInput;
   
    void Start()
    {
        Refresh();
    }


    void Update()
    {
        
    }
    public void Refresh()
    {
        
        textName.text = GameManager.instance.userData.name;
        textBarBallance.text = GameManager.instance.userData.balance.ToString();
        textCash.text = GameManager.instance.userData.cash.ToString();
        textBarBallance.text = string.Format("{0:#,###}",GameManager.instance.userData.balance);
        textCash.text = string.Format("{0:#,###}",GameManager.instance.userData.cash);
        
    }

    public void OntenThousandDesposButton()
    {
        UserData user = GameManager.instance.userData;
        
       
            if (user.cash < 10000)
            {

                lack.gameObject.SetActive(true);

            }
            else if (user.cash >= 10000)
            {
                GameManager.instance.userData.AddBalance(10000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
        
    }
    public void OnThreeThousandDesposButton()
    {
        UserData user = GameManager.instance.userData;
        
            if (user.cash < 30000)
            {

                lack.gameObject.SetActive(true);


            }
            else if (user.cash >= 30000)
            {
                GameManager.instance.userData.AddBalance(30000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }
    public void OnFiveThousandDesposButton()
    {
        UserData user = GameManager.instance.userData;
        
            if (user.cash < 50000)
            {

                lack.gameObject.SetActive(true);


            }
            else if (user.cash >= 50000)
            {
                GameManager.instance.userData.AddBalance(50000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }

    public void OnInputDesposButton()
    {
        int input = int.Parse(inputField_1.text);

        UserData user = GameManager.instance.userData;
        
            if (user.cash < input)
            {
                lack.gameObject.SetActive(true);
            }
            else if (user.cash >= input)
            {
                GameManager.instance.userData.AddBalance(input);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }
    public void OntenThousandWithdrawalButton()
    {
        UserData user = GameManager.instance.userData;
        
            if (user.balance < 10000)
            {
                lack.gameObject.SetActive(true);
            }
            else if (user.balance >= 10000)
            {

                GameManager.instance.userData.AddCash(10000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }
    public void OnThreeThousandWithdrawalButton()
    {
        UserData user = GameManager.instance.userData;
        
            if (user.balance < 30000)
            {
                lack.gameObject.SetActive(true);
            }
            else if (user.balance >= 30000)
            {
                GameManager.instance.userData.AddCash(30000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }
    public void OnFiveThousandWithdrawalButton()
    {
        UserData user = GameManager.instance.userData;
        
            if (user.balance < 50000)
            {
                lack.gameObject.SetActive(true);
            }
            else if (user.balance >= 50000)
            {

                GameManager.instance.userData.AddCash(50000);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }

    public void OnInpuWithdrawalButton()
    {
        int input = int.Parse(inputField_2.text);

        UserData user = GameManager.instance.userData;
        
            if (user.balance < input)
            {
                lack.gameObject.SetActive(true);
            }
            else if (user.balance >= input)
            {

                GameManager.instance.userData.AddCash(input);
                GameManager.instance.SaveUserData();
                PlayerPrefs.Save();
                Refresh();
            }
        
    }
    public void OnLackBack()
    {
        lack.SetActive(false);
    }

    public void Login()
    {
        string id = GameManager.instance.userData.id;
        string password = GameManager.instance.userData.password;
        if(id == idInput.text && password == passwordInput.text)
        {
            GameManager.instance.View.OnPopBank();
        }
        else
        {
            return;
        }
    }
}
