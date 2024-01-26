using UnityEngine;

namespace Code.Platforms
{
    public class RandomRotation : MonoBehaviour
    {
        private void Start()
        {
            Randomazer();
        }
        public void Randomazer()
        {
            float _value = Random.Range(0f, 360f);
            transform.Rotate(transform.rotation.x, transform.rotation.y, _value);
        }
    }
}
