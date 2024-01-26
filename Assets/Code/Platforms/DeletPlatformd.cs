using UnityEngine;

namespace Code.Platforms
{
    public class DeletPlatformd : MonoBehaviour
    {
        [SerializeField] private GameObject _parentPlatform;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(_parentPlatform);
            }
        }
    } 
    
}

