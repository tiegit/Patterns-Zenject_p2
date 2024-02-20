using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BallGame
{
    public class StartCanvasView : MonoBehaviour
    {
        [SerializeField] private Button _startCountModeButton;
        [SerializeField] private Button _startColorModeButton;

        private StartCanvasMediator _mediator;

        [Inject]
        private void Construct(StartCanvasMediator mediator)
        {
            _mediator = mediator;
        }

        private void Start()
        { 
            Show();
        }

        public void Show() => gameObject.SetActive(true);
        
        public void Hide() => gameObject.SetActive(false);

        private void OnEnable()
        {
            _startCountModeButton.onClick.AddListener(OnStartCountModeClick);
            _startColorModeButton.onClick.AddListener(OnStartColorModeClick);
        }

        private void OnDisable()
        {
            _startCountModeButton.onClick.RemoveListener(OnStartCountModeClick);
            _startColorModeButton.onClick.RemoveListener(OnStartColorModeClick);
        }

        private void OnStartCountModeClick() => _mediator.StartCountMode();
        
        private void OnStartColorModeClick() => _mediator.StartColorMode();
    }
}
