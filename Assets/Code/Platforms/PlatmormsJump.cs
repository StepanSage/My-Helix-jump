using UnityEngine;

namespace Code.Platforms
{
    public class PlatmormsJump : MonoBehaviour
    {
        private float _jumpForge = 7;
        private Rigidbody _playerRigedBody;

        private void Start() => _playerRigedBody = FindObjectOfType<Rigidbody>();

        private void OnCollisionEnter(Collision collision)
        {
            _playerRigedBody.velocity = Vector3.up * _jumpForge;
        }
    }
}
