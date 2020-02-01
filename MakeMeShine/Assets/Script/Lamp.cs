using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lamp : LogicValue
{
    public LogicValue input;
    public Sprite onLamp;
    public Sprite offLamp;

    private void Start()
    {
        input.valueUpdateEvent += UpdateValue;
        UpdateValue();
    }

    private void UpdateValue()
    {
        SetValue(input.output);

        //Mudar a imagem dependendo do valor do output
        var renderer = GetComponent<Image>();
        if (output)
        {
            renderer.sprite = onLamp;
        }
        else
        {
            renderer.sprite = offLamp;
        }
    }
}
