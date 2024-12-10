using TMPro;
using UnityEngine;

public class FormulaTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI formulaNameText;
    [SerializeField] private TextMeshProUGUI formulaText;
    [SerializeField] private CalculationTab calculationTab;
    [SerializeField] private ResultTab resultTab;

    public CalculationTab CalculationTab { get => calculationTab; }
    public ResultTab ResultTab { get => resultTab; }

    public void SetFormulaName(string formulaName)
    {
        formulaNameText.text = formulaName;
    }

    public void SetFormula(string formula)
    {
        formulaText.text = formula;
    }
}
