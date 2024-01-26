using UnityEngine;

namespace Code.StateGame 
{ 
    public class StartGame : MonoBehaviour
    {
        [SerializeField] private float _timeToStart;

        private Color _startColor;
        private float _decrise = 1f;
        private bool _isStart = false;

        private void Start()
        {
            _startColor = GetComponent<Renderer>().material.color;
        }

        private void Update()
        {
            InputStart();

            if (_isStart)
            {
                Calculater();
                OffStartPlatformsColor();
                DestroyPlatforms();
            }
        }

        private void InputStart()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _isStart = true;
            }
        }

        private void Calculater()
        {
            _timeToStart = _timeToStart - Time.deltaTime;
            _decrise = Mathf.Lerp(0, 1, _timeToStart);
        }

        private void OffStartPlatformsColor()
        { 
            this.GetComponent<Renderer>().material.color = new Vector4(_startColor.r, _startColor.g, _startColor.b, _decrise);
        }

        private void DestroyPlatforms()
        {
            if(_timeToStart < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}


