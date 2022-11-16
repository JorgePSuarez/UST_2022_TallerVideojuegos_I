using UnityEngine;

public class ReverseArray : MonoBehaviour
{
    [SerializeField] private int[] values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private void Start()
    {
        ReverseLog();
    }

    [ContextMenu(nameof(ReverseLog))]
    private void ReverseLog()
    {
        int[] reverse = Reverse(values);
        string reverseLog = "";
        for (int i = 0; i < reverse.Length; i++)
        {
            reverseLog += reverse[i].ToString() + ", ";
        }
        
        Debug.Log($"The reverse values are: {reverseLog}");
    }
    
    private int[] Reverse(int[] values)
    {
        int[] result = new int[values.Length];
        for (int i = values.Length - 1; i >= 0; i--)
        {
            result[values.Length - 1 - i] = values[i];
        }

        return result;
    }
}