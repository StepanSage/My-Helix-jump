using System;
using UnityEngine;

namespace Code.StateGame 
{ 
    public class WinGame : MonoBehaviour
    {
        public static Action<string> _winAction;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                _winAction?.Invoke("Победа");
            }
        }
    }
}


