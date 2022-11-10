using UnityEngine;

public class Trigger : MonoBehaviour
{
    public FallingBox box;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterMovement player = other.GetComponent<CharacterMovement>();
        if (player != null)
        {
            ResolveTrigger();
        }
        
    }
    
    public void ResolveTrigger()
    {
        box.Fall();
    }
}