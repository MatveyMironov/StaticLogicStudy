public class VariableTabController
{
    private readonly VariableTab _variableTab;
    private readonly Variable _variable;

    public VariableTabController(VariableTab variableTab, Variable variable)
    {
        _variableTab = variableTab;
        _variable = variable;

        _variableTab.SetName(_variable.Name);
        _variableTab.OnInputRecieved += SetVariableValue;
    }

    private void SetVariableValue(float value)
    {
        _variable.Value = value;
    }
}
