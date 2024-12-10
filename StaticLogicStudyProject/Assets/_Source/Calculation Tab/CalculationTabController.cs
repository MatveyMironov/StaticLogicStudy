using System.Collections.Generic;

public class CalculationTabController
{
    private CalculationTab _calculationTab;

    public CalculationTabController(CalculationTab calculationTab)
    {
        _calculationTab = calculationTab;
    }

    public void Setup(List<Variable> variables)
    {
        _calculationTab.DestroyAllVariableTabs();

        foreach (var variable in variables)
        {
            VariableTab variableTab = _calculationTab.CreateVariableTab();

            VariableTabController variableTabController = new(variableTab, variable);
        }
    }
}
