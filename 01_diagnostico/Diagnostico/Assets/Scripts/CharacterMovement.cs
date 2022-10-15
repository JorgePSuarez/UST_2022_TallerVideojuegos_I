using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]
public class CharacterMovement : MonoBehaviour
{
    private const string ANIM_MOVE_BOOL = "move";
    
    [SerializeField] private float movementSpeed = 5;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput != 0f)
        {
            transform.Translate(Vector3.right * movementSpeed * horizontalInput * Time.deltaTime);
            spriteRenderer.flipX = horizontalInput < 0;
            animator.SetBool(ANIM_MOVE_BOOL, true);
        }
        else if(animator.GetBool(ANIM_MOVE_BOOL))
            animator.SetBool(ANIM_MOVE_BOOL, false);
    }
}
