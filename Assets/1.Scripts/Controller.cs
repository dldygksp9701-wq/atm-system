using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.Controller = GetComponent<Controller>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
