using UnityEngine;

namespace Code.Platforms 
{
    public class PlatformsRotation : MonoBehaviour
    {
        [SerializeField] private float _speedRotaion;
        void Update()
        {
            Rotation();
        }

        public void Rotation()
        {
            if (Input.GetMouseButton(0))
            {
                float moveX = Input.GetAxisRaw("Mouse X");
                transform.Rotate(transform.rotation.x, -moveX * _speedRotaion * Time.deltaTime, transform.rotation.x);
            }
        }
    }
}

