﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,2,0));
    }

    void OnMouseDown()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}