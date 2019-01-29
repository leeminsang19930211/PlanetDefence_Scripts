﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastButtonCtrl : MonoBehaviour
{
    public GameObject m_fastButton_One = null;
    public GameObject m_fastButton_Double = null;

    void Start()
    {
        m_fastButton_One.SetActive(true);
        m_fastButton_Double.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnClick_FastButton_On()
    {
        m_fastButton_One.SetActive(false);
        m_fastButton_Double.SetActive(true);
    }

    public void OnClick_FastButton_Double()
    {
        m_fastButton_One.SetActive(true);
        m_fastButton_Double.SetActive(false);
    }
}
