﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    
    public GameObject prefab;

    
    void Awake (){
        InvokeRepeating ("Disparar", 2, 2);
    }
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparar (){
        Instantiate (prefab);
    }

}
