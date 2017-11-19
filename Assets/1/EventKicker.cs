using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKicker : MonoBehaviour
{
    public delegate void MyAction();
    public static event MyAction Kick;
    bool m_flg;

    void Update()
    {
        if (!m_flg)
        {
            m_flg = true;
            Debug.Log("Kick it.");
            Kick();
        }
    }
}
