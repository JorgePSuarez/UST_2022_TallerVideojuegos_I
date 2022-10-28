using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private FallingBox box;

    public void ResolveTrigger()
    {
        box.Fall();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterMovement player = other.GetComponent<CharacterMovement>();
        if (player != null)
        {
            ResolveTrigger();
        }
        
    }
}