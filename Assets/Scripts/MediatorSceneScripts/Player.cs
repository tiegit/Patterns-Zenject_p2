using UnityEngine;
using Zenject;

namespace MediatorSceneScripts
{
    public class Player : MonoBehaviour
    {
        private ViewPanelsMediator _viewPanelsMediator;

        private int _health;
        private int _maxHealth;
        private int _healthChangeValue;

        private int _playerLevel;
        private int _startPlayerLevel;
        private int _startPlayerHealth;

        protected int PlayerLevel
        {
            get => _playerLevel;
            private set => _playerLevel = value;
        }
        protected int PlayerHealth
        {
            get => _health;
            private set
            {
                if (value <= 0)
                {
                    _health = 0;
                    OnDefeat();
                }
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }

        [Inject]
        private void Construct(PlayerConfig playerConfig, ViewPanelsMediator viewPanelsMediator)        
        {
            _health = playerConfig.Health;
            _maxHealth = playerConfig.MaxHealth;
            _healthChangeValue = playerConfig.HealthChangeValue;

            _viewPanelsMediator = viewPanelsMediator;
        }

        private void Start()
        {
            _startPlayerLevel = PlayerLevel;
            _startPlayerHealth = PlayerHealth;

            RestartGame();
        }

        public void AddHealth()
        {
            PlayerHealth += _healthChangeValue;
            SetHealth(PlayerHealth);
        }

        public void RemoveHealth()
        {
            PlayerHealth -= _healthChangeValue;
            SetHealth(PlayerHealth);
        }

        public void IncreaseLevel()
        {
            PlayerLevel++;
            SetLevel(PlayerLevel);
        }

        public void RestartGame()
        {
            PlayerLevel = _startPlayerLevel;
            PlayerHealth = _startPlayerHealth;

            SetLevel(PlayerLevel);
            SetHealth(PlayerHealth);
        }

        private void OnDefeat() => _viewPanelsMediator.OnDefeat();

        private void SetLevel(int level) => _viewPanelsMediator.SetLevel(level);

        private void SetHealth(int health) => _viewPanelsMediator.SetHealth(health);
    }
}