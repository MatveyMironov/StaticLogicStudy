using System;
using System.Collections.Generic;

public class TwoVarFormulaController : FormulaController
{
    private readonly Func<float, float, float> _formula;

    public TwoVarFormulaController(Func<float, float, float> formula, string firstVariable, string secondVariable)
    {
        _formula = formula;

        List<string> variableNames = new()
        {
            firstVariable,
            secondVariable
        };

        CreateVariables(variableNames);
    }

    public override void Calculate()
    {
        float result = _formula.Invoke(_variables[0].Value, _variables[1].Value);

        InvokeOnResultChanged(result);
    }
}
