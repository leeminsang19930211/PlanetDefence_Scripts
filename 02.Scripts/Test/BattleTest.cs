﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTest : MonoBehaviour
{
    private int m_maxEnemCnt = 10;
    private int m_actvEnemCnt = 0;


    private int m_maxPlanetHP = 50;
    private int m_curPlanetHP = 50;

    private int m_gearCnt = 20;
    private int m_eleCircuitCnt = 20;
    private int m_coinCnt = 20;

    // Start is called before the first frame update
    void Start()
    {
        BattleGameObjectMgr.Inst.UpdateEnemyCnt(m_maxEnemCnt, m_actvEnemCnt);
        BattleGameObjectMgr.Inst.UpdatePlanetHP(m_maxPlanetHP, m_curPlanetHP);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneLoader.LoadScene("Lobby");
        }

        if(Input.GetKeyDown(KeyCode.F1))
        {
            m_actvEnemCnt += 1;

            if (m_actvEnemCnt > m_maxEnemCnt)
                m_actvEnemCnt = 0;

            BattleGameObjectMgr.Inst.UpdateEnemyCnt(m_maxEnemCnt, m_actvEnemCnt);

            m_curPlanetHP -= 5;

            if (m_curPlanetHP < 0)
                m_curPlanetHP = m_maxPlanetHP;

            BattleGameObjectMgr.Inst.UpdatePlanetHP(m_maxPlanetHP, m_curPlanetHP);

            m_gearCnt -= 1;
            m_eleCircuitCnt -= 1;
            m_coinCnt -= 1;

            if (m_gearCnt < 0)
                m_gearCnt = 20;
            if (m_eleCircuitCnt < 0)
                m_eleCircuitCnt = 20;
            if (m_coinCnt < 0)
                m_coinCnt = 20;

            BattleGameObjectMgr.Inst.UpdateJunkCnt(m_gearCnt);
            BattleGameObjectMgr.Inst.UpdateEleCircuitCnt(m_eleCircuitCnt);
            BattleGameObjectMgr.Inst.UpdateCoinCnt(m_coinCnt);
        }


    }
}
