using System;
using UnityEngine;

public class AverageGetter : MonoBehaviour
{
    [SerializeField] private int[] values = new int[] { 2, 5, 7, 7, 1 };

    private void Start()
    {
        CalculateAverageLog();
    }

    [ContextMenu(nameof(CalculateAverageLog))]
    private void CalculateAverageLog()
    {
        if (values.Length == 0)
        {
            Debug.LogError($"Add values in the inspector of object {gameObject.name}");
            return;
        }
        Debug.Log($"The average is: {CalculateAverage(values)}");
    }

    private float CalculateAverage(int[] values)
    {
        float result = 0;
        
        for (int i = 0; i < values.Length; i++)
        {
            result += values[i];
        }

        return result / values.Length;
    }
}