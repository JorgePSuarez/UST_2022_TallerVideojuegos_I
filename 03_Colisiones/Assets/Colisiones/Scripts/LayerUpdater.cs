using System;
using UnityEngine;

namespace Colisiones.Scripts
{
    public class LayerUpdater : MonoBehaviour
    {
        private string defaultLayer = "Default";
        private string invisibleLayer = "Player";

        private bool isInvisible = false;

        private void Start()
        {
            ChangeLayer();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isInvisible = !isInvisible;
                ChangeLayer();
            }
        }

        private void ChangeLayer()
        {
            if (isInvisible)
            {
                gameObject.layer = LayerMask.NameToLayer(defaultLayer);
            }
            else
            {
                gameObject.layer = LayerMask.NameToLayer(invisibleLayer);
            }
        }
    }
}