﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{ 
    private void OnCollisionEnter(UnityEngine.Collision other1)
    {
        
        Destroy(gameObject);
    }
}