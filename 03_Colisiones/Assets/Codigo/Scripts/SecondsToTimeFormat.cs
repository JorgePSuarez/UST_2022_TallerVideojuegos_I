using UnityEngine;

public class SecondsToTimeFormat : MonoBehaviour
{
    [SerializeField] private int timeInSeconds;

    private void Start()
    {
        Debug.Log(ConvertToTimeFormat(timeInSeconds));
    }

    private string ConvertToTimeFormat(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = seconds % 3600 / 60;
        int remainderSeconds = seconds % 60;

        return $"{hours.ToString("00")}:{minutes:00}:{remainderSeconds:00}";
    }
}
