using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : LogicValue
{
    public void click()
    {
        //Mudar o valor
        output = !output;

        //Atualizar visualmente
        SetValue(output);
    }
}
