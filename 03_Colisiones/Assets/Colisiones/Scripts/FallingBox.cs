using UnityEngine;

public class FallingBox : MonoBehaviour
{
    private Rigidbody2D rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.simulated = false;
    }

    public void Fall()
    {
        rig.simulated = true;
    }
}