using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace MediatorSceneScripts
{
    public class PlayerViewPanel : MonoBehaviour, IDisposable
    {
        [SerializeField] private TextMeshProUGUI _levelNumber;
        [SerializeField] private TextMeshProUGUI _healthCount;

        private ViewPanelsMediator _viewPanelsMediator;
        
        [Inject]
        private void Construct(ViewPanelsMediator viewPanelsMediator)
        {
            _viewPanelsMediator = viewPanelsMediator;
            _viewPanelsMediator.LevelChanged += OnLevelChanged;
            _viewPanelsMediator.HealthChanged += OnHealthChanged;
        }

        private void OnLevelChanged(int level) => _levelNumber.text = level.ToString();

        private void OnHealthChanged(int health) => _healthCount.text = health.ToString();

        public void Dispose()
        {
            _viewPanelsMediator.LevelChanged -= OnLevelChanged;
            _viewPanelsMediator.HealthChanged -= OnHealthChanged;
        }
    }
}