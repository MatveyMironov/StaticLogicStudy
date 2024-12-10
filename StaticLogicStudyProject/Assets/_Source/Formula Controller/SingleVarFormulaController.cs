using System;
using System.Collections.Generic;

public class SingleVarFormulaController : FormulaController
{
    private readonly Func<float, float> _formula;

    public SingleVarFormulaController(Func<float, float> formula, string singleVariable)
    {
        _formula = formula;

        List<string> variableNames = new()
        {
            singleVariable
        };

        CreateVariables(variableNames);
    }

    public override void Calculate()
    {
        float result = _formula.Invoke(_variables[0].Value);

        InvokeOnResultChanged(result);
    }
}
