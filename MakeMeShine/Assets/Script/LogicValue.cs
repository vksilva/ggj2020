using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LogicValue : MonoBehaviour
{
    public event Action valueUpdateEvent;
    public bool output;

    public void SetValue(bool value)
    {
        output = value;
        valueUpdateEvent?.Invoke();
    }
}
