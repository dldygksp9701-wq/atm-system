using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour 
{
    public static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindAnyObjectByType<GameManager>();
                if(instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(GameManager).Name;
                    instance = obj.AddComponent<GameManager>();
                }
            }
            return instance;
        }
        
    }

    public UserData userData;
    
   //프로퍼티: 변수인것처럼 쓰는 함수
    
    public View view;


    private Controller controller;
    public Controller Controller
    {
        get { return controller; }
        set { controller = value; }
    }

    private int balance = 0;
    private int cash = 0;
    public TMP_InputField sendInput;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        filePath = Path.Combine(Application.persistentDataPath, signName.text +".json");
        Debug.Log(filePath);
    }

    public TMP_InputField idInput;
    public TMP_InputField passwordInput;
    public TMP_InputField signInId;
    public TMP_InputField signInPassword;
    public TMP_InputField signName;
    public TMP_InputField signCash;
    public TMP_InputField signBalance;
    private string filePath;
    public GameObject error;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SaveUserData()
    {
        
        PlayerPrefs.SetInt("curCash", userData.cash);
        PlayerPrefs.SetInt("curBalance", userData.balance);
    }
    public void LoadUserData()
    {

        string json = File.ReadAllText(filePath);
        JObject data = JObject.Parse(json);
        UserData userData = new UserData(data);
        
    }
    public void SaveJson()
    {
        if(string.IsNullOrEmpty(signName.text)
            || string.IsNullOrEmpty(signInPassword.text)
            || string.IsNullOrEmpty(signInId.text)
            || string.IsNullOrEmpty(signCash.text)
            || string.IsNullOrEmpty(signBalance.text))
        {
            error.SetActive(true);
            return;
        }
        else
        {
            int balance = int.Parse(signBalance.text);
            int cash = int.Parse(signCash.text);
            JObject json = new JObject();
            json["name"] = signInId.text;
            json["id"] = signInId.text;
            json["password"] = balance;
            json["balance"] = cash;
            json["cash"] = signCash.text;

            System.IO.File.WriteAllText(filePath, json.ToString());
            Debug.Log("[SaveJson] 저장 완료");
            Debug.Log("[SaveJson] filePath = " + filePath);
            Debug.Log("[SaveJson] json = " + json.ToString());
        }
    }


    

    public void Login()
    {
      

        string json = File.ReadAllText(filePath);
        JObject data = JObject.Parse(json);

        if ((string)data["id"] == idInput.text && (string)data["password"] == passwordInput.text)
        {
            GameManager.instance.view.OnPopBank();
            GameManager.instance.userData = new UserData(data);
        }

        else
        {
            return;
        }
    }
    public void SendBalance()
    {
        int balance = int.Parse(signBalance.text);
        int cash = int.Parse(signCash.text);
        if(File.Exists(filePath))
        {
            if (GameManager.instance.userData.balance < balance)
            {
                return;
            }
            else
            {
                
            }
        }
        
    }
}
