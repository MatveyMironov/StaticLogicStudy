using System;
using System.Collections.Generic;

public class ThreeVarFormulaController : FormulaController
{
    private readonly Func<float, float, float, float> _formula;

    public ThreeVarFormulaController(Func<float, float, float, float> formula, string firstVariable, string secondVariable, string thirdVariable)
    {
        _formula = formula;

        List<string> variableNames = new()
        {
            firstVariable,
            secondVariable,
            thirdVariable
        };

        CreateVariables(variableNames);
    }

    public override void Calculate()
    {
        float result = _formula.Invoke(_variables[0].Value, _variables[1].Value, _variables[2].Value);

        InvokeOnResultChanged(result);
    }
}
