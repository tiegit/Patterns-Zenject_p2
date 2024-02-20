using UnityEngine;
using Zenject;

namespace MediatorSceneScripts
{
    public class PlayerInput : ITickable
    {
        private PlayerInputMediator _playerInputMediator;

        [Inject]
        private void Construct(PlayerInputMediator playerInputMediator) => _playerInputMediator = playerInputMediator;
        
        public void Tick()
        {
            bool levelUp = Input.GetKeyDown(KeyCode.L);
            bool healthAdd = Input.GetKeyDown(KeyCode.UpArrow);
            bool healthReduce = Input.GetKeyDown(KeyCode.DownArrow);

            if (levelUp) _playerInputMediator.IncreaseLevel();

            if (healthAdd) _playerInputMediator.AddHealth();

            if (healthReduce) _playerInputMediator.RemoveHealth();
        }
    }
}