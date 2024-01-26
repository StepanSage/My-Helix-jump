using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.UI 
{ 
    public class RestartGame : MonoBehaviour
    {
        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }
}

