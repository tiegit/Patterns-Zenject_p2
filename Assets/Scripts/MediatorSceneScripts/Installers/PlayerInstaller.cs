using UnityEngine;
using Zenject;

namespace MediatorSceneScripts
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private Player _player;

        public override void InstallBindings()
        {
            BindConfig();
            BindInstance();
            BindPlayerInput();
        }        
        
        private void BindConfig() => Container.Bind<PlayerConfig>().FromInstance(_playerConfig).AsSingle();
        
        private void BindInstance() => Container.Bind<Player>().FromInstance(_player).AsSingle();

        private void BindPlayerInput() => Container.BindInterfacesAndSelfTo<PlayerInput>().AsSingle();
    }
}
