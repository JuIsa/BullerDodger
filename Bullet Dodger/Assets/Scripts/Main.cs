﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] EnemyMain enemyMain;
    
    public static EnemyMain EnemyMain => Instance.enemyMain;

    private static Main _instance;
    

    private static Main Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindGameObjectWithTag("Main")?.GetComponent<Main>();
            return _instance;
        }
    }
}