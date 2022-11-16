using System;
using UnityEngine;

public class VowelCounter : MonoBehaviour
{
    private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };
    
    [SerializeField] private string inputText = "Hello World!";

    private void Start()
    {
        VowelCounterLog();
    }

    [ContextMenu(nameof(VowelCounterLog))]
    private void VowelCounterLog()
    {
        Debug.Log($"The vowels in text {inputText} are: {CountVowels(inputText)}");
    }

    private int CountVowels(string text)
    {
        int result = 0;
        char[] textChar = text.ToLower().ToCharArray();
        
        for (int i = 0; i < textChar.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (textChar[i] == vowels[j])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}