using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MediatorSceneScripts
{
    public class DefeatPanel : MonoBehaviour, IDisposable
    {
        [SerializeField] private Button _restartButton;

        private ViewPanelsMediator _viewPanelsMediator;
        private PlayerInputMediator _playerInputMediator;

        [Inject]
        private void Construct(ViewPanelsMediator viewPanelMediator, PlayerInputMediator playerInputMediator)
        {
            _viewPanelsMediator = viewPanelMediator;
            _playerInputMediator = playerInputMediator;

            Initialize();
        }

        private void Initialize()
        {
            _viewPanelsMediator.DefeatPanelOpened += OnDefeatPanelOpened;
            HidePanel();
        }

        public void ShowPanel() => gameObject.SetActive(true);

        public void HidePanel() => gameObject.SetActive(false);

        private void OnEnable() => _restartButton.onClick.AddListener(OnRestartClick);

        private void OnDisable() => _restartButton.onClick.RemoveListener(OnRestartClick);

        private void OnDefeatPanelOpened()
        {
            ShowPanel();
            BlockPlayerInputBeforRestart();
        }

        private void OnRestartClick()
        {
            HidePanel();
            _playerInputMediator.RestartGame();

            UnblockPlayerInputAfterRestart();
        }

        private void BlockPlayerInputBeforRestart() => _playerInputMediator.BlockPlayerInput();

        private void UnblockPlayerInputAfterRestart() => _playerInputMediator.UnblockPlayerInput();

        public void Dispose()=> _viewPanelsMediator.DefeatPanelOpened -= OnDefeatPanelOpened;
    }
}
