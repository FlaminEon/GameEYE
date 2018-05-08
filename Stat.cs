using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript barra;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
            this.currentVal = value;
            barra.Value = currentVal;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            this.maxVal = value;
            barra.MaxValue = maxVal;
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }
    
}
