using System;
using TMPro;
using UnityEngine;

public class VariableTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI variableNameText;
    [SerializeField] private TMP_InputField valueInputField;

    public event Action<float> OnInputRecieved;

    private void Awake()
    {
        valueInputField.onEndEdit.AddListener(RecieveInput);
    }

    public TMP_InputField ValueInputField { get => valueInputField; }

    public void SetName(string name)
    {
        variableNameText.text = name;
    }

    private void RecieveInput(string input)
    {
        float value = float.Parse(input);

        OnInputRecieved?.Invoke(value);
    }
}
