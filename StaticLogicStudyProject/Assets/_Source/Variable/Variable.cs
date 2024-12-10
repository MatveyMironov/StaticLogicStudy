using System;

public class Variable
{
    private readonly string _name;
    private float _value;

    public Variable(string name)
    {
        _name = name;
        _value = 0;
    }

    public event Action OnValueChanged;

    public string Name { get { return _name; } }
    public float Value { get { return _value; } set { ChangeValue(value); } }

    private void ChangeValue(float value)
    {
        _value = value;
        OnValueChanged?.Invoke();
    }
}
