using System;
using UnityEngine;

namespace Ejemplo2
{
    public class Personaje : MonoBehaviour
    {
        public float velocidad;
        private Rigidbody2D rigid;

        private void Awake()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        public void Mover()
        {
            //transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            rigid.AddForce(Vector2.right * velocidad, ForceMode2D.Force);
        }

        private void FixedUpdate()
        {
            // Obtener input del jugador
            
            Mover();
        }
    }
}