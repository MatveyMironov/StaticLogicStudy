using UnityEngine;

public class ConstantDataHolder : MonoBehaviour
{
    [SerializeField] private ConstantDataSO constantDataSO;

    private static ConstantData _constantData;
    public static ConstantData ConstantData
    {
        get
        {
            _constantData ??= new ConstantData();

            return _constantData;
        }
    }

    private void Awake()
    {
        _constantData = constantDataSO.ConstantData;
    }
}
