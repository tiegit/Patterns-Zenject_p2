using UnityEngine;

namespace BallGame
{
    public class BallPicker : MonoBehaviour
    {
        private Camera _camera;

        private void Start() => _camera = Camera.main;

        private void Update()
        {
            if (_camera == null ||
                Input.GetMouseButtonDown(0) == false)
                return;

            if (Input.GetMouseButtonDown(0) &&
                Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit))
            {
                Transform ballTransform = hit.transform.parent;

                if (ballTransform != null)
                {
                    ballTransform.TryGetComponent<Ball>(out var ball);

                    ball.Select();
                }
            }
        }
    }
}
