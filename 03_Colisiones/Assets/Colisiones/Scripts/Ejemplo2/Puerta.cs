using System;
using UnityEngine;

namespace Ejemplo2
{
    public class Puerta : MonoBehaviour
    {
        private Animator anim;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        public void OpenDeDoor()
        {
            anim.Play("comsome_con_papas");
        }
    }
}