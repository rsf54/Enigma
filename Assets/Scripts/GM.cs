﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GM : MonoBehaviour
{
    public static bool Win = false;
    public static int indexer;
    // Start is called before the first frame update
    void Start()
    {
         indexer = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
