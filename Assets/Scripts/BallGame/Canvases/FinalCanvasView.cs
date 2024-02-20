using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BallGame
{
    public class FinalCanvasView : MonoBehaviour
    {
        [SerializeField] private Button _exitToMenuButton;
        [SerializeField] private Button _resetCurrentModeButton;

        private FinalCanvasMediator _finalCanvasMediator;


        [Inject]
        private void Construct(FinalCanvasMediator finalCanvasMediator) => _finalCanvasMediator = finalCanvasMediator;
        
        public void Show() => gameObject.SetActive(true);

        public void Hide() => gameObject.SetActive(false);

        private void OnEnable()
        {
            _exitToMenuButton.onClick.AddListener(OnExitToMenuButtonClick);
            _resetCurrentModeButton.onClick.AddListener(OnResetCurrentModeButtonClick);
        }

        private void OnDisable()
        {
            _exitToMenuButton.onClick.RemoveListener(OnExitToMenuButtonClick);
            _resetCurrentModeButton.onClick.RemoveListener(OnResetCurrentModeButtonClick);
        }

        private void OnExitToMenuButtonClick() => _finalCanvasMediator.ExitToMenu();

        private void OnResetCurrentModeButtonClick() => _finalCanvasMediator.ResetCurrentMode();
    }
}
