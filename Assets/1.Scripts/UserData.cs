using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;





//[System.Serializable]
public class UserData
{
    public string name;
    public int balance;
    public int cash;
    public string id;
    public string password;

    public UserData(JObject json)
    {
        name = (string)json["name"];
        balance = (int)json["balance"];
        cash = (int)json["cash"];
        id = (string)json["id"];
        password = (string)json["password"];
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