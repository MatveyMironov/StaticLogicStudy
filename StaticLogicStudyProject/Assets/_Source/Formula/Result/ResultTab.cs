using TMPro;
using UnityEngine;

public class ResultTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;

    public void DisplayResult(float result)
    {
        resultText.text = result.ToString();
    }
}
