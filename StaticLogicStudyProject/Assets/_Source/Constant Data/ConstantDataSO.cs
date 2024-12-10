using UnityEngine;

[CreateAssetMenu(fileName = "NewConstantData", menuName = "Constant Data")]
public class ConstantDataSO : ScriptableObject
{
    [SerializeField] private ConstantData constantData;

    public ConstantData ConstantData { get => constantData; }
}
