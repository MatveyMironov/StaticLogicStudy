public class FormulaTabController
{
    private FormulaTab _formulaTab;

    public FormulaTabController(FormulaTab formulaTab)
    {
        _formulaTab = formulaTab;
    }

    public void Setup(FormulaController calculationController)
    {
        CalculationTabController calculationTabController = new(_formulaTab.CalculationTab);
        calculationTabController.Setup(calculationController.Variables);

        calculationController.OnResultChanged += _formulaTab.ResultTab.DisplayResult;
    }
}
