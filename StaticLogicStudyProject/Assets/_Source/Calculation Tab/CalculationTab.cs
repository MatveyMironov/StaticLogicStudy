using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculationTab : MonoBehaviour
{
    [SerializeField] private Transform content;
    [SerializeField] private VariableTab variableTabPrefab;

    private List<VariableTab> createdVariableTabs = new();

    public VariableTab CreateVariableTab()
    {
        VariableTab variableTab = Instantiate(variableTabPrefab, content);
        createdVariableTabs.Add(variableTab);

        return variableTab;
    }

    public void DestroyAllVariableTabs()
    {
        foreach (VariableTab variableTab in createdVariableTabs)
        {
            Destroy(variableTab.gameObject);
        }

        createdVariableTabs.Clear();
    }
}
