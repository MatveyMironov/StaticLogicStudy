using System;
using System.Collections.Generic;

public abstract class FormulaController
{
    protected List<Variable> _variables;

    public List<Variable> Variables { get => _variables; }

    public event Action<float> OnResultChanged;

    public abstract void Calculate();

    protected void CreateVariables(List<string> variableNames)
    {
        _variables = new();

        foreach (var variableName in variableNames)
        {
            Variable variable = new(variableName);
            variable.OnValueChanged += Calculate;
            _variables.Add(variable);
        }
    }

    protected void InvokeOnResultChanged(float result)
    {
        OnResultChanged?.Invoke(result);
    }
}
