using Code.StateGame;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.UI
{ 
    public class Menu : MonoBehaviour
    {
        [SerializeField] Image _menu;
        [SerializeField] TMP_Text _text;

        private void OnEnable()
        {  
            WinGame._winAction += OpenMenu;
        }

        private void OnDestroy()
        {
            WinGame._winAction -= OpenMenu;
        }

        public void OpenMenu(string titel)
        {
            _menu.gameObject.SetActive(true);
            _text.text= titel;
        }
    }
}
