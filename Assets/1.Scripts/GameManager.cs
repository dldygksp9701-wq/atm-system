using System.Collections;
using System.Collections.Generic;
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
    
    private View view;
    public View View
    {
        get { return view; }
        set { view = value; }
    }

    private Controller controller;
    public Controller Controller
    {
        get { return controller; }
        set { controller = value; }
    }

    private bool isCashSave;
    private bool isBalanceSave;
    
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
    }
    void Start()
    {
        LoadUserData();
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
       
        if(PlayerPrefs.HasKey("curCash"))
        {
             userData.cash = PlayerPrefs.GetInt("curCash", userData.cash);
        }
        if (PlayerPrefs.HasKey("curBalance"))
        {
            userData.balance = PlayerPrefs.GetInt("curBalance", userData.balance);
        }
    }

}
