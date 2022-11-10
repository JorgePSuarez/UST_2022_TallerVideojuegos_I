using System;
using UnityEngine;

namespace Ejemplo2
{
    public class Llave : MonoBehaviour
    {
        public Puerta door;
        private Collider2D coll;


        private void OnTriggerEnter2D(Collider2D otro)
        {
            door.OpenDeDoor();
        }
        
    }
}