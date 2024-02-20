using UnityEngine;

namespace MediatorSceneScripts
{
    [CreateAssetMenu(menuName = "Configs/PlayerConfig", fileName = "PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private int _health = 50;
        [SerializeField] private int _maxHealth = 100;
        [SerializeField] private int _healthChangeValue = 10;

        public int Health => _health;
        public int MaxHealth => _maxHealth;
        public int HealthChangeValue => _healthChangeValue;
    }
}