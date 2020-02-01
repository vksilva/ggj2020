using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicGate : LogicValue
{
    public List<LogicValue> inputs;
    public Text text;
    public GateType type;
    public enum GateType {
        And,
        Or,
        Not
    }

    private void Start()
    {
        foreach(var input in inputs)
        {
            input.valueUpdateEvent += UpdateValue;
        }

        UpdateValue();
    }

    public void UpdateValue()
    {
        switch (type)
        {
            case GateType.And:
                UpdateAnd();                
                break;

            case GateType.Not:
                UpdateNot();
                break;

            case GateType.Or:
                UpdateOr();
                break;
        }

        text.text = output.ToString();
    }

    private void UpdateAnd()
    {
        foreach (var input in inputs)
        {
            if(input.output == false)
            {
                SetValue(false);
                return;
            }
        }
        SetValue(true);
    }

    private void UpdateOr()
    {
        foreach (var input in inputs)
        {
            if (input.output == true)
            {
                SetValue(true);
                return;
            }
        }
        SetValue(false);

    }

    private void UpdateNot()
    {
        foreach (var input in inputs)
        {
            SetValue(!input.output);
        }
    }
}
