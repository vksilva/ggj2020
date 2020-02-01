using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInputButton : LogicValue
{
    public Text text;

    private void Start()
    {
        text.text = output.ToString();        
    }

    public void click()
    {
        //Mudar o valor
        output = !output;

        //Atualizar visualmente
        text.text = output.ToString();

        SetValue(output);
    }
    
}
