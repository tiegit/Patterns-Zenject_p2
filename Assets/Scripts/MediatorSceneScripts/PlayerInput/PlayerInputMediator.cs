using Zenject;

namespace MediatorSceneScripts
{
    public class PlayerInputMediator
    {
        private Player _player;
        public bool IsBlocked { get; private set; }

        [Inject]
        private void Construct(Player player) => _player = player;
        
        public void IncreaseLevel()
        {
            if (IsBlocked == false)
                _player.IncreaseLevel();
        }

        public void AddHealth()
        {
            if (IsBlocked == false)
                _player.AddHealth();
        }

        public void RemoveHealth()
        {
            if (IsBlocked == false)
                _player.RemoveHealth();
        }

        public void RestartGame() => _player.RestartGame();

        public void BlockPlayerInput() => IsBlocked = true;
        
        public void UnblockPlayerInput() => IsBlocked = false;        
    }
}
