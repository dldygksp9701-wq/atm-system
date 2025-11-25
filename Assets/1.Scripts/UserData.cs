using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




[System.Serializable]
public class UserData
{
    public string name;
    public int balance;
    public int cash;
    public string id;
    public string password;

    //회원가입을 하는 방식을 json으로 하려고 하는데 저번에 강의를 하신 jtoken을
    //이용하려고 하는데 도저히 어떤 방식으로 해야 하는지 모르겠습니다.
    //저번 강의 때는 json 데이터를 가져오는 것을 했다면 데이터를 json으로 저장을 해야하는데 알려주실수 있나요?

    public UserData(string name, int balance, int cash, string id, string password)
    {
        this.name = name;
        this.balance = balance;
        this.cash = cash;
        this.id = id;
        this.password = password;
    }

    public void AddBalance(int value)
    {
        cash = Mathf.Max(cash, 0);
        balance += value;
        cash -= value;
    }

    public void AddCash(int value)
    {
        balance = Mathf.Max(balance, 0);
        balance -= value;
        cash += value;
    }
}
//들어오는거랑 가져가는거랑 다르면 프로퍼티를 사용한다.

//생성자는 인스턴스를 새로 만들 때 쓰는 양식이다
//생성자를 사용하는 이유와
//프로퍼티를 사용하는 이유