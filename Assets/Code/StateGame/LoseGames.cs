using Code.UI;
using UnityEngine;

namespace Code.StateGame
{
    public class LoseGames : MonoBehaviour
    {
        private Rigidbody _playerRigetBody;
        private Menu _menu;

        private void Start()
        {
            _playerRigetBody = FindObjectOfType<Rigidbody>();  
            _menu = FindObjectOfType<Menu>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                _menu.OpenMenu("Поражение");
                Destroy(collision.gameObject);
          
            }
       
        }

   
    }
}

